using System;

public class WalletPresenter : AWalletPresenter
{
    public WalletPresenter(AWalletView aWalletView, AWalletModel aWalletModel) : base(aWalletView, aWalletModel) { }


    public override void Activate()
    {
        _aWalletModel.OnCoinsChanged += WalletModel_OnCoinsChanged;
    }

    public override void Deactivate()
    {
        _aWalletModel.OnCoinsChanged -= WalletModel_OnCoinsChanged;
    }
    public override void WalletModel_OnCoinsChanged(int coins)
    {
        _aWalletView.ChangeCoinsTo(coins);
    }
}
