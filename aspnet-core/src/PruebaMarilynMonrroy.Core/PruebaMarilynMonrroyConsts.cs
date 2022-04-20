using PruebaMarilynMonrroy.Debugging;

namespace PruebaMarilynMonrroy
{
    public class PruebaMarilynMonrroyConsts
    {
        public const string LocalizationSourceName = "PruebaMarilynMonrroy";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d887de571d554c128d2274ee0a3e098b";
    }
}
