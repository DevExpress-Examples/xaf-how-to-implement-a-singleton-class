using DevExpress.ExpressApp.DC;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;

namespace HowToImplementSingleton.Module {
	public class ShowSingletonController : WindowController {
		public ShowSingletonController() {
            this.TargetWindowType = WindowType.Main;
            PopupWindowShowAction showSingletonAction = 
                new PopupWindowShowAction(this, "ShowSingleton", PredefinedCategory.View);
            showSingletonAction.CustomizePopupWindowParams += showSingletonAction_CustomizePopupWindowParams;
		}
        private void showSingletonAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
            DetailView detailView = Application.CreateDetailView(objectSpace, objectSpace.GetObjects<Singleton>()[0]);
            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
		}
	}
}
