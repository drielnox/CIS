
using CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.MaritalStatus
{
    class NewMaritalStatusPresenter : Presenter<INewMaritalStatusView>
    {
        public NewMaritalStatusPresenter(INewMaritalStatusView view) : base(view)
        {
        }
    }
}
