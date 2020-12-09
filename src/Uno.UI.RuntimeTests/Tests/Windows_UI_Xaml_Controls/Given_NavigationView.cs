﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Private.Infrastructure;
using Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls.ListViewPages;
#if NETFX_CORE
using Uno.UI.Extensions;
#elif __IOS__
using UIKit;
#elif __MACOS__
using AppKit;
#else
using Uno.UI;
#endif
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using static Private.Infrastructure.TestServices;
using Uno.Extensions;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls
{
	[TestClass]
	[RunsOnUIThread]
	public partial class Given_NavigationView
	{
		[TestMethod]
		[RunsOnUIThread]
		public async Task When_NavView()
		{
			var SUT = new NavigationView() { IsSettingsVisible = false};
			SUT.MenuItems.Add(new NavigationViewItem { DataContext = this, Content = "Item 1" });

			WindowHelper.WindowContent = SUT;

			await WindowHelper.WaitForIdle();

			var list = SUT.FindName("MenuItemsHost") as NavigationViewList;
			var panel = list.ItemsPanelRoot;

			Assert.IsNotNull(panel);

			NavigationViewItem item2 = null;
			await SUT.Dispatcher.RunIdleAsync(a => SUT.MenuItems.Add(new NavigationViewItem() { DataContext = this, Content = "Item 2" }));
			await SUT.Dispatcher.RunIdleAsync(a => SUT.MenuItems.RemoveAt(1));
			await SUT.Dispatcher.RunIdleAsync(a => SUT.MenuItems.Add(item2 = new NavigationViewItem() { DataContext = this, Content = "Item 2" }));

			await WindowHelper.WaitForIdle();

			Assert.AreEqual(item2, panel.Children.Last());
		}
	}
}
