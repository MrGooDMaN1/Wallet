using System;
using UnityEngine;

public abstract class AWalletModel : IModel
{
    public static AWalletModel Instance { get; protected set; }
    public int StandartCoins { get; protected set; }
    public int PremiumCoins { get; protected set; }

    public event Action<int> StandartCoinsChanged;
    public event Action<int> PremiumCoinsChanged;

    public AWalletModel()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Second Wallet model created");
        }
    }

    public AWalletModel(int startStandardCoins, int startPremiumCoins)
    {
        StandartCoins = startStandardCoins;
        PremiumCoins = startPremiumCoins;
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Second Wallet model created");
        }
    }

    protected void OnStandartCoinsChanged(int coins)
    {
        StandartCoinsChanged?.Invoke(coins);
    }
    protected void OnPremiumCoinsChanged(int coins)
    {
        PremiumCoinsChanged?.Invoke(coins);
    }

    public abstract void AddStandardCoins(int value);
    public abstract void AddPremiumCoins(int value);

    public abstract bool TrySpendStandardCoins(int value);
    public abstract bool TrySpendPremiumCoins(int value);
}
