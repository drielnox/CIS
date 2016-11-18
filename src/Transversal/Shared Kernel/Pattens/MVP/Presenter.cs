namespace CIS.Transversal.SharedKernel.Pattens.MVP
{
    public abstract class Presenter<TView>
        where TView : IView
    {
        public TView View { get; protected set; }

        public Presenter(TView view)
        {
            View = view;
        }
    }
}
