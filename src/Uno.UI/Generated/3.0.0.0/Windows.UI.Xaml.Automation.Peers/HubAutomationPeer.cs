#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HubAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public HubAutomationPeer( global::Windows.UI.Xaml.Controls.Hub owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.HubAutomationPeer", "HubAutomationPeer.HubAutomationPeer(Hub owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.HubAutomationPeer.HubAutomationPeer(Windows.UI.Xaml.Controls.Hub)
	}
}
