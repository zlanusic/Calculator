using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresentationLogicLayer_MVP.LoginPresenter
{
    /// <summary>
    /// Abstract Interface koji predstavlja LoginView
    /// Prikaz forme na monitoru
    /// </summary>
    public interface ILogonView : INotify
    {
        // --getters za svako txtbox polje
        string UserName { get; }
        string UserPwd { get; }

        // --event za klik "Prijava" button-a
        event EventHandler LoginEvent;

        // --event za klik "Odustani" button-a
        event EventHandler CloseEvent;
    }
}
