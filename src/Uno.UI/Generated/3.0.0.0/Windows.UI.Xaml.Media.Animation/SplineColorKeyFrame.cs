#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplineColorKeyFrame : global::Windows.UI.Xaml.Media.Animation.ColorKeyFrame
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Animation.KeySpline KeySpline
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.KeySpline)this.GetValue(KeySplineProperty);
			}
			set
			{
				this.SetValue(KeySplineProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeySplineProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeySpline), typeof(global::Windows.UI.Xaml.Media.Animation.KeySpline), 
			typeof(global::Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.KeySpline)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame.SplineColorKeyFrame()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame.SplineColorKeyFrame()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame.KeySpline.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame.KeySpline.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame.KeySplineProperty.get
	}
}
