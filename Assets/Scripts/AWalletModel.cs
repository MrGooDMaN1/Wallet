using System;

public abstract class AWalletModel : IModel
{
    public static AWalletModel Instance { get; protected set; }
    public int StandardCoins { get; protected set; }
    public int PremiumCoins { get; protected set; }

    public event Action<int> OnCoinsChanged;

    public AWalletModel()
    {
        if (Instance == null)
            Instance = this;
    }

    public AWalletModel(int startStandardCoins, int startPremiumCoins)
    {
        StandardCoins = startStandardCoins;
        PremiumCoins = startPremiumCoins;
        if (Instance == null)
            Instance = this;
    }

    public virtual void AddStandardCoins(int value) 
    {
        OnCoinsChanged?.Invoke(StandardCoins);
    }
    public virtual void AddPremiumCoins(int value)
    {
        OnCoinsChanged?.Invoke(PremiumCoins);
    }

    public virtual bool TrySpendStandardCoins(int value)
    {
        OnCoinsChanged?.Invoke(StandardCoins);
        return true;
    }
    public virtual bool TrySpendPremiumCoins(int value)
    {
        OnCoinsChanged?.Invoke(PremiumCoins);
        return true;
    }
}
