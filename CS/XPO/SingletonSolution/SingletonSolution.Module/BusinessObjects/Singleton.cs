using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSolution.Module.BusinessObjects {
    [RuleObjectExists("AnotherSingletonExists", DefaultContexts.Save, "True", InvertResult = true,
     CustomMessageTemplate = "Another Singleton already exists.")]
    [RuleCriteria("CannotDeleteSingleton", DefaultContexts.Delete, "False",
     CustomMessageTemplate = "Cannot delete Singleton.")]
    public class Singleton : BaseObject {
        public Singleton(Session session) : base(session) { }
        private string name;
        public string Name {
            get { return name; }
            set {
                SetPropertyValue("Name", ref name, value);
            }
        }
        private string description;
        public string Description {
            get { return description; }
            set {
                SetPropertyValue("Description", ref description, value);
            }
        }
    }
}
