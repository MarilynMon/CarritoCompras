using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PruebaMarilynMonrroy.Localization
{
    public static class PruebaMarilynMonrroyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PruebaMarilynMonrroyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PruebaMarilynMonrroyLocalizationConfigurer).GetAssembly(),
                        "PruebaMarilynMonrroy.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
