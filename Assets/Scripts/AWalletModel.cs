using System;
using UnityEngine;

public abstract class AWalletModel : IModel
{
    public static AWalletModel Instance { get; protected set; }
    public int Coins { get; protected set; }

    public event Action<int> CoinsChanged;

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
        Coins = startStandardCoins;
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Second Wallet model created");
        }
    }

    protected void OnCoinsChanged(int coins)
    {
        CoinsChanged?.Invoke(coins);
    }

    public abstract void AddCoins(int value); //

    public abstract bool TrySpendCoins(int value);
}
