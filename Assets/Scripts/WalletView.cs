using TMPro;

public class WalletView : AWalletView
{
    public TextMeshProUGUI _text;

    public WalletView(TextMeshProUGUI text)
    {
        _text = text;
    }

    public override void ChangeStandartCoinsTo(int value)
    {
        _text.text = value.ToString();
    }

    public override void ChangePremiumCoinsTo(int value)
    {
        _text.text = value.ToString();
    }
}
