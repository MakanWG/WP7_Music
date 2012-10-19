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
using WG.Presentation.Phone.ViewModels;

namespace Songkick.Presentation.Phone.Account
{
    public class AccountPageViewModel : ViewModelBase
    {
        public string AccountName
        {
            get { return GetValue<string>("AccountName", string.Empty); }
            set { SetValue("AccountName", value); }
        }

        public ICommand SetAccountCommand
        {
            get { return GetValue<ICommand>("SetAccountCommand", null); }
            set { SetValue("SetAccountCommand", value); }
        }

        public AccountPageViewModel()
        {
            AccountName = string.Empty;
            SetAccountCommand = new WGCommand(_ =>
                                                  {
                                                      this.BusinessServices()
                                                          .Account
                                                          .SetAccountName(AccountName);
                                                      this.Services().Navigation.NavigateBack();
                                                  });
        }

        public override void Charged()
        {
            AccountName = this.BusinessServices()
                                .Account
                                .GetAccountName();
        }
    }
}
