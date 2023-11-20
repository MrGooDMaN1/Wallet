using TMPro;

public abstract class AWalletView : IView
{
    public abstract void ChangeStandartCoinsTo(int value);
    
    public abstract void ChangePremiumCoinsTo(int value);
}
