using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PresentationLogicLayer_MVP.LoginPresenter;
using DataAccessLayer.Services;

namespace PresentationLogicLayer_MVP.LoginPresenter
{
    /// <summary>
    /// Presenter implementira business logic, tj. logiranje korisnika!! 
    /// </summary>
    public class LogonViewPresenter
    {
        /// <summary>
        /// Kreiramo private field ILogonView interface-a
        /// </summary>
        private readonly ILogonView _mlogonView;

        /// <summary>
        /// Overload konstruktora za primanje ILogonView interface-a
        /// Inicijalizira novu instancu LogonViewPresenter klase
        /// </summary>
        /// <param name="logonView"></param>
        public LogonViewPresenter(ILogonView logonView)
        {
            // --registriramo view
            this._mlogonView = logonView;

            //osluskujemo view login event 
            this._mlogonView.LoginEvent += new EventHandler(_mloginView_LoginEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _mloginView_LoginEvent(object sender, EventArgs e)
        {
            var userName = _mlogonView.UserName;
            var userPwd = _mlogonView.UserPwd;

            LogonService logonService = new LogonService(_mlogonView);
            logonService.Logon(userName, userPwd);

        }

        public void Init()
        {
        }

    }
}
