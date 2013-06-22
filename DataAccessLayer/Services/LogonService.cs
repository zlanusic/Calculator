using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using PresentationLogicLayer_MVP.LoginPresenter;

namespace DataAccessLayer.Services
{
    public class LogonService
    {
        private readonly PrincipalContext _principalContext = new PrincipalContext(ContextType.Domain);
        private readonly INotify _mNotifier;

        public LogonService(INotify notifier)
        {
            _mNotifier = notifier;
        }

        public bool Logon(string userName, string password)
        {
            if (!_principalContext.ValidateCredentials(userName, password, ContextOptions.Negotiate))
            {
                _mNotifier.Notify("Neispravno korisničko ime ili lozinka!");
            }
            else
            {
                _mNotifier.Notify("Uspješna prijava!");
            }
            return false;
        }
    }
}
