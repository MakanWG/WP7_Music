using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Songkick.Business.Phone.Contracts
{
    public interface IAccountBusinessService
    {
        string GetAccountName();

        void SetAccountName(string accountName);
    }
}
