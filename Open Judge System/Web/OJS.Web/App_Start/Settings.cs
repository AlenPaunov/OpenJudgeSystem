﻿namespace OJS.Web
{
    using static OJS.Workers.Common.Helpers.SettingsHelper;

    public static class Settings
    {
        public static string SulsApiKey => GetSetting("SulsApiKey");
        
        public static string ApiKey => GetSetting("ApiKey");

        public static string CSharpCompilerPath => GetSetting("CSharpCompilerPath");

        public static string DotNetCompilerPath => GetSetting("DotNetCompilerPath");

        public static string DotNetDisassemblerPath => GetSetting("DotNetDisassemblerPath");

        public static string JavaCompilerPath => GetSetting("JavaCompilerPath");

        public static string JavaDisassemblerPath => GetSetting("JavaDisassemblerPath");

        public static string SulsPlatformBaseUrl => GetSetting("SulsPlatformBaseUrl");

        public static string SvnBaseUrl => GetSetting("SvnBaseUrl");

        public static string LearningSystemSvnDownloadBaseUrl => GetSetting("LearningSystemSvnDownloadBaseUrl");

        public static int CSharpCompilerProcessExitTimeOutMultiplier =>
            GetSettingOrDefault("CSharpCompilerProcessExitTimeOutMultiplier", 1);

        public static int JavaCompilerProcessExitTimeOutMultiplier =>
            GetSettingOrDefault("JavaCompilerProcessExitTimeOutMultiplier", 1);

        public static int ThrottleLimitPerSecond => GetIntSetting("ThrottleLimitPerSecond");

        public static int ThrottleLimitPerMinute => GetIntSetting("ThrottleLimitPerMinute");

        public static int ThrottleLimitPerHour => GetIntSetting("ThrottleLimitPerHour");

        public static int ThrottleLimitPerDay => GetIntSetting("ThrottleLimitPerDay");

        public static string[] ThrottleIpWhitelist => GetSetting("ThrottleIpWhitelist").Split(',');

        public static int DatabaseCommandTimeoutInSeconds => GetSettingOrDefault("DatabaseCommandTimeoutInSeconds", 30);

        public static int ArchiveSingleBatchLimit => GetSettingOrDefault("ArchiveSingleBatchLimit", 25000);

        public static int ArchiveMaxSubBatchSize => GetSettingOrDefault("ArchiveMaxSubBatchSize", 10000);

        public static int ArchiveDailyBatchSize => GetSettingOrDefault("ArchiveDailyBatchSize", 500000);

        private static int GetIntSetting(string settingName) => int.Parse(GetSetting(settingName));
    }
}