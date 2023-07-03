// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmSample.Core.Models;
using MvvmSample.Core.Services;
using Nito.AsyncEx;

namespace MvvmSample.Core.ViewModels.Widgets;

/// <summary>
/// A viewmodel for a subreddit widget.
/// </summary>
public sealed class SubredditWidgetViewModel : ObservableRecipient
{
    /// <summary>
    /// Gets the <see cref="IRedditService"/> instance to use.
    /// </summary>
    private readonly IRedditService RedditService;

    /// <summary>
    /// Gets the <see cref="ISettingsService"/> instance to use.
    /// </summary>
    private readonly ISettingsService SettingsService;

    /// <summary>
    /// An <see cref="AsyncLock"/> instance to avoid concurrent requests.
    /// </summary>
    private readonly AsyncLock LoadingLock = new();

    /// <summary>
    /// Creates a new <see cref="SubredditWidgetViewModel"/> instance.
    /// </summary>
    public SubredditWidgetViewModel(IRedditService redditService, ISettingsService settingsService)
    {
        RedditService = redditService;
        SettingsService = settingsService;

        LoadPostsCommand = new AsyncRelayCommand(LoadPostsAsync);

        selectedSubreddit = SettingsService.GetValue<string>(nameof(SelectedSubreddit)) ?? Subreddits[0];
    }

    /// <summary>
    /// Gets the <see cref="IAsyncRelayCommand"/> instance responsible for loading posts.
    /// </summary>
    public IAsyncRelayCommand LoadPostsCommand { get; }

    /// <summary>
    /// Gets the collection of loaded posts.
    /// </summary>
    public ObservableCollection<Post> Posts { get; } = new();

    /// <summary>
    /// Gets the collection of available subreddits to pick from.
    /// </summary>
    public IReadOnlyList<string> Subreddits { get; } = new[]
    {
        "10",
        "100",
        "1000"
    };

    private string selectedSubreddit;

    /// <summary>
    /// Gets or sets the currently selected subreddit.
    /// </summary>
    public string SelectedSubreddit
    {
        get => selectedSubreddit;
        set
        {
            SetProperty(ref selectedSubreddit, value);

            SettingsService.SetValue(nameof(SelectedSubreddit), value);
        }
    }

    private Post? selectedPost;

    /// <summary>
    /// Gets or sets the currently selected post, if any.
    /// </summary>
    public Post? SelectedPost
    {
        get => selectedPost;
        set => SetProperty(ref selectedPost, value, true);
    }

    /// <summary>
    /// Loads the posts from a specified subreddit.
    /// </summary>
    private async Task LoadPostsAsync()
    {
        Posts.Clear();
        using (await LoadingLock.LockAsync())
        {
            PostsQueryResponse response = await RedditService.GetSubredditPostsAsync(100, SelectedSubreddit);
            foreach (Post item in response!.Items!)
            {
                Posts.Add(item!);
            }
        }
    }
}
