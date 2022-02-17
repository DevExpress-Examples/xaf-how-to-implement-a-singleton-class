using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;

namespace HowToImplementSingleton.Module {
	public class Updater : ModuleUpdater {
		public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
		public override void UpdateDatabaseAfterUpdateSchema() {
			base.UpdateDatabaseAfterUpdateSchema();
			//Create the Singleton object
			if (ObjectSpace.GetObjectsCount(typeof(Singleton), null) == 0) {
				Singleton singleton = ObjectSpace.CreateObject<Singleton>();
				singleton.Name = "My Singleton";
				singleton.Description = "Sample Description";
			}
			ObjectSpace.CommitChanges();
		}
	}
}
