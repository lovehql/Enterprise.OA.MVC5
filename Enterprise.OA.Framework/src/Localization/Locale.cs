using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Enterprise.OA.Framework.Localization
{
    public static class Locale
    {
        private static CultureInfo _defaultCulture;

        public static CultureInfo DefaultCulture
        {
            get { return _defaultCulture; }
        }

        private static IEnumerable<CultureInfo> _registerCultures;

        public static IEnumerable<CultureInfo> RegisterCultures
        {
            get { return _registerCultures; }
        }

        public static void Configure(CultureInfo defaultCulture, params CultureInfo[] registerCultures)
        {
            if (defaultCulture == null)
                throw new ArgumentNullException(nameof(defaultCulture));

            if (registerCultures == null)
                throw new ArgumentNullException(nameof(registerCultures));

            _defaultCulture = defaultCulture;

            _registerCultures = registerCultures.Union(new CultureInfo[] { defaultCulture }).Distinct();
        }

        public static void Configure(string defaultCultureName, params string[] registerCultureNames)
        {
            if (string.IsNullOrWhiteSpace(defaultCultureName))
                throw new ArgumentNullException(nameof(defaultCultureName));

            if (registerCultureNames == null)
                registerCultureNames = new string[] { defaultCultureName };

            CultureInfo defaultCulture = CultureInfo.GetCultureInfo(defaultCultureName);

            CultureInfo[] registerCultures = registerCultureNames.Select(cultureName => CultureInfo.GetCultureInfo(cultureName)).ToArray();

            Configure(defaultCulture, registerCultures);
        }

        public static bool Contains(string cultureName)
        {
            return RegisterCultures.Any(registerCulture => string.Equals(registerCulture.Name, cultureName, StringComparison.CurrentCultureIgnoreCase));
        }

        private static CultureInfo GetCulture(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
                throw new ArgumentNullException(nameof(cultureName));

            return RegisterCultures.Where(registerCulture => string.Equals(registerCulture.Name, cultureName, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault();
        }

        private static void SetCulture(CultureInfo culture)
        {
            if (culture == null)
                throw new ArgumentNullException(nameof(culture));

            Thread.CurrentThread.CurrentCulture = culture;

            Thread.CurrentThread.CurrentUICulture = culture;
        }

        public static void SetCulture(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
                throw new ArgumentNullException(nameof(cultureName));

            CultureInfo culture = GetCulture(cultureName);

            if (culture == null)
            {
                throw new CultureNotFoundException();
            }
            else
            {
                SetCulture(culture);
            }
        }

        public static void SetDefaultCulture()
        {
            SetCulture(DefaultCulture);
        }
    }
}
