using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
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
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
