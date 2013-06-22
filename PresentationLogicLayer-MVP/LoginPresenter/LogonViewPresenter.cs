using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PresentationLogicLayer_MVP.LoginPresenter;
using DataAccessLayer.Services;

namespace PresentationLogicLayer_MVP.LoginPresenter
{
    public class LogonViewPresenter
    {
        private readonly ILogonView _mloginView;

        //konstruktor
        public LogonViewPresenter(ILogonView loginView)
        {
            // --registriramo view
            this._mloginView = loginView;
            //osluskujemo view login event 
            this._mloginView.LoginEvent += new EventHandler(_mloginView_LoginEvent);
        }

        void _mloginView_LoginEvent(object sender, EventArgs e)
        {
            var userName = _mloginView.UserName;
            var userPwd = _mloginView.UserPwd;

            LogonService logonService = new LogonService(_mloginView);
            logonService.Logon(userName, userPwd);

        }

        public void Init()
        {
        }

    }
}
