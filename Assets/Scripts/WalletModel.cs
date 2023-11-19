using System;

public class WalletModel : AWalletModel
{
    public override void AddStandardCoins(int value)
    {
        StandardCoins += value;
        base.AddStandardCoins(value);
    }
    public override void AddPremiumCoins(int value)
    {
        PremiumCoins += value;
        base.AddPremiumCoins(value);
    }

    public override bool TrySpendStandardCoins(int value)
    {
        if(value > StandardCoins)
            return false;

        StandardCoins -= value;
        base.TrySpendStandardCoins(value);
        return true;
    }
    public override bool TrySpendPremiumCoins(int value)
    {
        if (value > PremiumCoins)
            return false;

       PremiumCoins -= value;
       base .TrySpendPremiumCoins(value);
        return true;
    }
}
