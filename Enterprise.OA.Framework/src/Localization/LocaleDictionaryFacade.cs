using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.OA.Framework.Localization
{
    public class LocaleDictionaryFacade : LocaleResolverFacadeBase<IDictionary<string,CultureInfo>>
    {
        private readonly string _defaultLocale;

        public LocaleDictionaryFacade(string key, CultureInfo culture) 
            : base(new Dictionary<string, CultureInfo>())
        {
            Register(key, culture);

            _defaultLocale = key;
        }

        public override ICollection<string> Locales
        {
            get
            {
                return Execute<ICollection<string>>(dictionary => dictionary.Keys);
            }
        }

        public override string DefaultLocale
        {
            get { return _defaultLocale; }
        }

        public override ILocaleResolverFacade Register(string key, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override CultureInfo Resolve(string key)
        {
            throw new NotImplementedException();
        }
    }
}
