﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmSample.Core.ViewModels.Widgets;
using Windows.UI.Xaml.Controls;

namespace MvvmSampleUwp.Views.Widgets;

public sealed partial class SubredditWidget : UserControl
{
    public SubredditWidget()
    {
        this.InitializeComponent();

        DataContext = Ioc.Default.GetRequiredService<SubredditWidgetViewModel>();
    }

    public SubredditWidgetViewModel ViewModel => (SubredditWidgetViewModel)DataContext;
}
