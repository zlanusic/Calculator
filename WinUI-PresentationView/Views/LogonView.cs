﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentationLogicLayer_MVP.LoginPresenter;

namespace WinUI_PresentationView.Views
{
    /// <summary>
    /// Uvijek implementira view interface
    /// </summary>
    public partial class LogonView : Form, ILogonView
    {
        private readonly LogonViewPresenter _loginViewPresenter;

        //konstruktor
        public LogonView()
        {
            InitializeComponent();

            _loginViewPresenter = new LogonViewPresenter(this);
        }


        #region ILoginView Properties

        public event EventHandler LoginEvent;
        public event EventHandler CloseEvent;

        // --dohvatiti korisnicko ime
        public string UserName 
        {
            // --uvijek .Trim() i vratiti .ToLower() slova
            get { return mTxtBoxUserName.Text.Trim().ToLower(); }
        }

        // --dohvatiti lozinku
        public string UserPwd
        {
            get { return mTxtBoxPwd.Text; }
        }

        //update view sa porukom
        public void Notify(string notification)
        {
            //za sada!!!
            mTsslNotification.Text = notification;
        }

        #endregion

        private void mbtnOK_Click(object sender, EventArgs e)
        {
            //okini event kada user klikne na button za prijavu
            if (LoginEvent != null)
            {
                LoginEvent(this, EventArgs.Empty);
            }

        }
    }
}
