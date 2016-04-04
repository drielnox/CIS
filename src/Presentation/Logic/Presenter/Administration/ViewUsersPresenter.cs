using CIS.Application.BusinessComponents;
using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewUsersPresenter
    {
        private IViewUsersView _view;
        private ChannelFactory<IAdministrationContract> channel;

        public ViewUsersPresenter(IViewUsersView view)
        {
            _view = view;
            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public void AddUser()
        {
            var result = _view.ShowAddUserDialog();

            _view.RefreshUserList();
        }

        public void ChangeUserPassword()
        {
            var user = _view.GetSelectedUser();
            _view.ShowChangeUserPasswordDialog(user);
        }

        public void LoadUserList()
        {
            UserViewModel users;

            try
            {
                using (var proxy = channel.CreateChannel())
                {
                    users = proxy.GetUsers();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            _view.LoadUserList(users);
        }
    }
}
