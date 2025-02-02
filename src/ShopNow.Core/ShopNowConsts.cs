using ShopNow.Debugging;

namespace ShopNow
{
    public class ShopNowConsts
    {
        public const string LocalizationSourceName = "ShopNow";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "471d842128c64af1bea2a453599ff36c";
    }
}
