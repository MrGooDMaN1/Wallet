using UnityEngine;

public abstract class AWalletStarter : MonoBehaviour
{
    protected AWalletView _view;
    protected AWalletModel _model;

    protected void Awake()
    {
        CreateWalletModel();
    }

    protected void Start()
    {
        CreateWalletView();
        CreateWalletPresenter();
    }

    private void CreateWalletPresenter()
    {
        new WalletPresenter(_view, _model);
    }

    protected abstract void CreateWalletModel();

    protected abstract void CreateWalletView();

}
