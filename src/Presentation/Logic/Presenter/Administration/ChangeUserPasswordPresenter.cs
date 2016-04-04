using CIS.Application.BusinessComponents;
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ChangeUserPasswordPresenter
    {
        private IChangeUserPasswordView _view;

        private ChannelFactory<IAdministrationContract> channel;

        public ChangeUserPasswordPresenter(IChangeUserPasswordView view)
        {
            _view = view;

            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public bool ValidatePassword(string p)
        {
            return string.IsNullOrWhiteSpace(p);
        }

        public bool PasswordsAreEquals(string p1, string p2)
        {
            return p1.Equals(p2);
        }

        public void Save()
        {
            ChangeUserPasswordViewModel data = _view.GetFormData();

            try
            {
                using (var proxy = channel.CreateChannel())
                {
                    proxy.ChangePassword(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
