using CIS.Application.BusinessComponents;
using CIS.Presentation.UI.Contracts.Administration;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class NewUserPresenter
    {
        private INewUserView _view;
        private UserBusinessLogic _logic;

        public NewUserPresenter(INewUserView view)
        {
            _view = view;
            _logic = new UserBusinessLogic();
        }

        public void SaveUser()
        {
            var data = _view.GetUserData();
            _logic.Save(data);
        }
    }
}
