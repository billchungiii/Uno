#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct UniversalApiContract 
	{
		// Forced skipping of method Windows.Foundation.UniversalApiContract.UniversalApiContract()
	}
}
