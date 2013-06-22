using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresentationLogicLayer_MVP.LoginPresenter
{
    public interface INotify
    {
        // --za status field, da li je login bio uspjesan ili nije
        void Notify(string notification);
    }
}
