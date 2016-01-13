using CIS.Presentation.Model;
using CIS.Presentation.UI.Contracts;
using System;
using System.Collections.Generic;

namespace CIS.Presentation.Logic.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
        }

        public void Login()
        {
            LoginViewModel data = _view.GetFormData();
        }

        public bool ValidateUsername(string p)
        {
            return !string.IsNullOrWhiteSpace(p);
        }

        public bool ValidatePassword(string p)
        {
            return !string.IsNullOrWhiteSpace(p);
        }
    }
}
