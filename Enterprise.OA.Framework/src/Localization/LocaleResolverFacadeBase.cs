using System;
using System.Collections.Generic;
using System.Globalization;

namespace Enterprise.OA.Framework.Localization
{
    public abstract class LocaleResolverFacadeBase<TResolver> : FacadeBase<TResolver>, ILocaleResolverFacade<TResolver>
    {
        public LocaleResolverFacadeBase(TResolver resolver)
            : base(() => resolver)
        {
            if (resolver == null)
            {
                throw new ArgumentNullException(nameof(resolver));
            }
        }

        public abstract ICollection<string> Locales { get; }

        public abstract string DefaultLocale { get; }

        public abstract ILocaleResolverFacade Register(string key, CultureInfo culture);

        public CultureInfo Resolve()
        {
            return Resolve(DefaultLocale);
        }

        public abstract CultureInfo Resolve(string key);
    }
}
