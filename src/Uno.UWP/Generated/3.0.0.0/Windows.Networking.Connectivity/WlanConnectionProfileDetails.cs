#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WlanConnectionProfileDetails 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string GetConnectedSsid()
		{
			throw new global::System.NotImplementedException("The member string WlanConnectionProfileDetails.GetConnectedSsid() is not implemented in Uno.");
		}
		#endif
	}
}
