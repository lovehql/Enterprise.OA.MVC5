using System;

namespace Enterprise.OA.Framework.Localization
{
    public static class LocalizationMiddleware
    {
        private static Func<ILocaleResolverFacade> _localeResolverFacadeAccessor;

        public static ILocaleResolverFacade Current
        {
            get { return _localeResolverFacadeAccessor.Invoke(); }
        }

        public static void Initialize(Func<ILocaleResolverFacade> localResolverFacadeAccessor)
        {
            _localeResolverFacadeAccessor = localResolverFacadeAccessor;
        }
    }
}
