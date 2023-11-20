public abstract class AWalletPresenter : IPresenter
{
    protected AWalletView _view;
    protected AWalletModel _model;

    public AWalletPresenter(AWalletView view, AWalletModel model)
    {
        _view = view;
        _model = model;
        Activate();
    }

    public abstract void Activate();
    public abstract void Deactivate();
}
