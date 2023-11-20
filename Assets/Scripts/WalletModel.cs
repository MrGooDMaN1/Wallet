public class WalletModel : AWalletModel
{
    public override void AddStandardCoins(int value)
    {
        StandartCoins += value;
        OnStandartCoinsChanged(StandartCoins);
    }

    public override void AddPremiumCoins(int value)
    {
        PremiumCoins += value;
        OnPremiumCoinsChanged(PremiumCoins);
    }

    public override bool TrySpendStandardCoins(int value)
    {
        if(value > StandartCoins)
            return false;

        StandartCoins -= value;
        OnStandartCoinsChanged(StandartCoins);
        return true;
    }

    public override bool TrySpendPremiumCoins(int value)
    {
        if (value > PremiumCoins)
            return false;

       PremiumCoins -= value;
        OnPremiumCoinsChanged(PremiumCoins);
        return true;
    }
}
