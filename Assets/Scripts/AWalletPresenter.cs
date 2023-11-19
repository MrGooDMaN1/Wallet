using System;

public abstract class AWalletPresenter : IPresenter
{
    protected AWalletView _aWalletView;
    protected AWalletModel _aWalletModel;

    public AWalletPresenter(AWalletView aWalletView, AWalletModel aWalletModel)
    {
        this._aWalletView = aWalletView;
        this._aWalletModel = aWalletModel;
        _aWalletModel = AWalletModel.Instance;
        _aWalletView.ChangeCoinsTo(AWalletModel.Instance.StandardCoins);
        _aWalletView.ChangeCoinsTo(AWalletModel.Instance.PremiumCoins);
        Activate();
    }

    public abstract void Activate();
    public abstract void Deactivate();
    public abstract void WalletModel_OnCoinsChanged(int coins);
}
