using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using SingletonSolution.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SingletonSolution.Module.Controllers {
    public class ShowSingletonController : WindowController {
        public ShowSingletonController() {
            this.TargetWindowType = WindowType.Main;
            PopupWindowShowAction showSingletonAction =
                new PopupWindowShowAction(this, "ShowSingleton", PredefinedCategory.View);
            showSingletonAction.CustomizePopupWindowParams += showSingletonAction_CustomizePopupWindowParams;
        }
        private void showSingletonAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Singleton));
            DetailView detailView = Application.CreateDetailView(objectSpace, objectSpace.GetObjects<Singleton>()[0]);
            e.View = detailView;
        }
    }
}
