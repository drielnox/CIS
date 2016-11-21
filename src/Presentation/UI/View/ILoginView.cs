namespace CIS.Presentation.UI.Contracts
{
    using Model;
    using Transversal.SharedKernel.Patterns.MVP;

    public interface ILoginView : IView
    {
        LoginViewModel GetFormData();
    }
}
