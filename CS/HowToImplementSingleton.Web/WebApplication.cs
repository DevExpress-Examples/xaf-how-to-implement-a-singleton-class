using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace HowToImplementSingleton.Web {
	public partial class HowToImplementSingletonAspNetApplication : WebApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection, true);
        }
		private DevExpress.ExpressApp.SystemModule.SystemModule module1;
		private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private HowToImplementSingleton.Module.HowToImplementSingletonModule howToImplementSingletonModule1;
		private HowToImplementSingleton.Module.HowToImplementSingletonModule module3;
        public HowToImplementSingletonAspNetApplication() {
			InitializeComponent();
		}

		private void HowToImplementSingletonAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
		    e.Updater.Update();
			e.Handled = true;
		}

		private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new HowToImplementSingleton.Module.HowToImplementSingletonModule();
            this.howToImplementSingletonModule1 = new HowToImplementSingleton.Module.HowToImplementSingletonModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // HowToImplementSingletonAspNetApplication
            // 
            this.ApplicationName = "HowToImplementSingleton";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.howToImplementSingletonModule1);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.HowToImplementSingletonAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
	}
}
