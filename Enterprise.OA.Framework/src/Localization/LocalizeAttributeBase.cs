using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Enterprise.OA.Framework.Localization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public abstract class LocalizeAttributeBase : ActionFilterAttribute
    {
        public const string LocalRouteSegment = "locale";

        private readonly object _typeId = new object();

        public override object TypeId
        {
            get { return _typeId; }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }

            string locale;

            try
            {
                locale = filterContext.RouteData.Values[LocalRouteSegment].ToString();
                Apply(locale); Save(locale);
                return;
            }
            catch { }

            try
            {

            }
            catch { }
        }

        protected virtual void Apply(string locale)
        {

        }

        protected abstract void Save(string locale);

        protected abstract void Load();
    }
}
