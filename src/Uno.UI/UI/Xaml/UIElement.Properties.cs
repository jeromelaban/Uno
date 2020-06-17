﻿#if NET461 || __WASM__
#pragma warning disable CS0067
#endif

using Windows.Foundation;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System.Collections.Generic;
using Uno.Extensions;
using Uno.Logging;
using Uno.Disposables;
using System.Linq;
using Windows.Devices.Input;
using Windows.System;
using Windows.UI.Xaml.Controls;
using Uno.UI;
using Uno;
using Uno.UI.Controls;
using Uno.UI.Media;
using System;
using System.Numerics;
using System.Reflection;
using Windows.UI.Xaml.Markup;
using Microsoft.Extensions.Logging;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Core;
using Uno.UI.Xaml;

#if __IOS__
using UIKit;
#endif

namespace Windows.UI.Xaml
{
	public partial class UIElement : DependencyObject, IXUidProvider
	{
		[GeneratedDependencyProperty(DefaultValue = true, ChangedCallback = true)]
		public bool IsHitTestVisible
		{
			get => GetIsHitTestVisibleValue();
			set => SetIsHitTestVisibleValue(value);
		}

		[GeneratedDependencyProperty(DefaultValue = 1.0, ChangedCallback = true)]
		public double Opacity
		{
			get => GetOpacityValue();
			set => SetOpacityValue(value);
		}

		/// <summary>
		/// Sets the visibility of the current view
		/// </summary>
		[GeneratedDependencyProperty(DefaultValue = Visibility.Visible, ChangedCallback = true)]
		public
#if __ANDROID__
		new
#endif
		Visibility Visibility
		{
			get => GetVisibilityValue();
			set => SetVisibilityValue(value);
		}

		[GeneratedDependencyProperty(DefaultValue = null, ChangedCallback = true)]
		public FlyoutBase ContextFlyout
		{
			get => GetContextFlyoutValue();
			set => SetContextFlyoutValue(value);
		}

		[GeneratedDependencyProperty(DefaultValue = null, IsPublic = false)]
		public IList<KeyboardAccelerator> KeyboardAccelerators
		{
			get => GetKeyboardAcceleratorsValue();
			set => SetKeyboardAcceleratorsValue(value);
		}

#if HAS_UNO_WINUI
		[GeneratedDependencyProperty(DefaultValue = FocusState.Unfocused)]
		public FocusState FocusState
		{
			get => GetFocusState();
			internal set => SetFocusState(value);
		}

		[GeneratedDependencyProperty(DefaultValue = true, ChangedCallback = true)]
		public bool IsTabStop
		{
			get => GetIsTabStop();
			set => SetIsTabStop(value);
		}

		private protected virtual void OnIsTabStopChanged(bool oldValue, bool newValue) { }
#endif
	}
}
