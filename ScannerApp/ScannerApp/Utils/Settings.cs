using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace ScannerApp.Utils
{
    public class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants
        private const string SessionCodeToken = "SessionCodeToken";
        private static readonly string DefaultSessionCode = string.Empty;
        private const string EmployeeIdToken = "EmployeeIdToken";
        private static readonly string DefaultEmployeeIdToken = string.Empty;

        private const string StationIdToken = "StationIdToken";
        private static readonly string DefaultStationId = string.Empty;

        private const string UserNameToken = "UserNameToken";
        private static readonly string DefaultUserName = string.Empty;
        private const string PasswordToken = "PasswordToken";
        private static readonly string DefaultPassword = string.Empty;

      
        #endregion


        #region Setting Properties
        public static string SessionCode
        {
            get => AppSettings.GetValueOrDefault(SessionCodeToken, DefaultSessionCode);
            set => AppSettings.AddOrUpdateValue(SessionCodeToken, value);
        }

        public static string EmployeeID
        {
            get => AppSettings.GetValueOrDefault(EmployeeIdToken,DefaultEmployeeIdToken);
            set => AppSettings.AddOrUpdateValue(EmployeeIdToken, value);
        }
        public static string StationID
        {
            get => AppSettings.GetValueOrDefault(StationIdToken, DefaultSessionCode);
            set => AppSettings.AddOrUpdateValue(StationIdToken, value);
        }
        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(UserNameToken, DefaultUserName);
            set => AppSettings.AddOrUpdateValue(UserNameToken, value);
        }
        public static string Password
        {
            get => AppSettings.GetValueOrDefault(PasswordToken, DefaultPassword);
            set => AppSettings.AddOrUpdateValue(PasswordToken, value);
        }
        #endregion

    }
}
