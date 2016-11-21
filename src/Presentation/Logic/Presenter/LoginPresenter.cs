using CIS.Presentation.Model;
using CIS.Presentation.UI.Contracts;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        public LoginPresenter(ILoginView view)
            : base(view)
        {
        }

        public void Login()
        {
            LoginViewModel data = View.GetFormData();
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
