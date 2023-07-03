// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;
using MvvmSample.Core.Models;
using Refit;

namespace MvvmSample.Core.Services;

/// <summary>
/// An interface for a simple Reddit service.
/// </summary>
public interface IRedditService
{
    /// <summary>
    /// https://eztv.re/api/get-torrents?limit=10&page=1
    /// </summary>
    /// <param name="subreddit">The subreddit name.</param>
    [Get("/api/get-torrents?limit={limit}&page={page}")]
    Task<PostsQueryResponse> GetSubredditPostsAsync(int page, string limit);
}
