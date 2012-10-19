using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Songkick.Business.Phone.Contracts;
using WG.Tools.Phone.Contracts;

namespace Songkick.Business.Phone.Services
{
    public class AccountBusinessService : IAccountBusinessService
    {
        private ISettingsService _settingsService;
        public AccountBusinessService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public string GetAccountName()
        {
            if (_settingsService.IsKeyStored(Constants.SettingsValues.AccountName))
            {
                return _settingsService.GetSetting(Constants.SettingsValues.AccountName).ToString();
            }
            return string.Empty;
        }

        public void SetAccountName(string accountName)
        {
            _settingsService.SaveSetting(Constants.SettingsValues.AccountName, accountName);
        }
    }
}
