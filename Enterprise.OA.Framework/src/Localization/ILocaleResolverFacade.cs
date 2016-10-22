using System.Collections.Generic;
using System.Globalization;

namespace Enterprise.OA.Framework.Localization
{
    public interface ILocaleResolverFacade
    {
        ICollection<string> Locales { get; }

        string DefaultLocale { get; }

        ILocaleResolverFacade Register(string key, CultureInfo culture);

        CultureInfo Resolve();

        CultureInfo Resolve(string key);
    }

    public interface ILocaleResolverFacade<TResolver> : ILocaleResolverFacade
    {
    }
}
