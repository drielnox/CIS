using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class NewUserPresenter
    {
        private INewUserView _view;

        private ChannelFactory<IAdministrationContract> channel;

        public NewUserPresenter(INewUserView view)
        {
            _view = view;
            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public void SaveUser()
        {
            NewUserViewModel data = _view.GetUserData();

            try
            {
                using (var proxy = channel.CreateChannel())
                {
                    proxy.Save(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
