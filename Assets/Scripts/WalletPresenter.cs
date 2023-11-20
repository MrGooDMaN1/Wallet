public class WalletPresenter : AWalletPresenter
{
    public WalletPresenter(AWalletView walletView, AWalletModel walletModel) : base(walletView, walletModel) 
    {
        _view.ChangeStandartCoinsTo(AWalletModel.Instance.StandartCoins);
        _view.ChangePremiumCoinsTo(AWalletModel.Instance.PremiumCoins);
    }


    public override void Activate()
    {
        _model.StandartCoinsChanged += WalletModel_OnStandartCoinsChanged;
        _model.PremiumCoinsChanged += WalletModel_OnPremiumCoinsChanged;
    }

    public override void Deactivate()
    {
        _model.StandartCoinsChanged -= WalletModel_OnStandartCoinsChanged;
        _model.PremiumCoinsChanged -= WalletModel_OnPremiumCoinsChanged;
    }

    public void WalletModel_OnStandartCoinsChanged(int coins)
    {
        _view.ChangeStandartCoinsTo(coins);
    }

    public void WalletModel_OnPremiumCoinsChanged(int coins)
    {
        _view.ChangePremiumCoinsTo(coins);
    }
}
