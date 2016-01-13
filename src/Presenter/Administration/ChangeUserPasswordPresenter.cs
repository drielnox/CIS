using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ChangeUserPasswordPresenter
    {
        private IChangeUserPasswordView _view;
        private UserBusinessLogic _logic;

        public ChangeUserPasswordPresenter(IChangeUserPasswordView view)
        {
            _view = view;
            _logic = new UserBusinessLogic();
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
            _logic.ChangePassword(data);
        }
    }
}
