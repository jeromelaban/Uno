#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Power.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BackgroundEnergyDiagnostics 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public static double DeviceSpecificConversionFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member double BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public static ulong ComputeTotalEnergyUsage()
		{
			throw new global::System.NotImplementedException("The member ulong BackgroundEnergyDiagnostics.ComputeTotalEnergyUsage() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void ResetTotalEnergyUsage()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics", "void BackgroundEnergyDiagnostics.ResetTotalEnergyUsage()");
		}
		#endif
	}
}
