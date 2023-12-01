public class PremiumWalletModel : AWalletModel
{
    public override void AddCoins(int value)
    {
        Coins += value;
        OnCoinsChanged(Coins);
    }

    public override bool TrySpendCoins(int value)
    {
        if (value > Coins)
            return false;

        Coins -= value;
        OnCoinsChanged(Coins);
        return true;
    }
}
