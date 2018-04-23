using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;

namespace HowToImplementSingleton.Win {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
#if EASYTEST
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			HowToImplementSingletonWindowsFormsApplication application = new HowToImplementSingletonWindowsFormsApplication();
			try {
                InMemoryDataStoreProvider.Register();
    			application.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
				application.Setup();
				application.Start();
			}
			catch(Exception e) {
				application.HandleException(e);
			}
		}
	}
}
