public class WalletPresenter : AWalletPresenter
{
    public WalletPresenter(AWalletView walletView, AWalletModel walletModel) : base(walletView, walletModel) 
    {
        _view.ChangeCoinsTo(AWalletModel.Instance.Coins);    }


    public override void Activate()
    {
        _model.CoinsChanged += WalletModel_OnCoinsChanged;
    }

    public override void Deactivate()
    {
        _model.CoinsChanged -= WalletModel_OnCoinsChanged;
    }

    public void WalletModel_OnCoinsChanged(int coins)
    {
        _view.ChangeCoinsTo(coins);
    }
}
