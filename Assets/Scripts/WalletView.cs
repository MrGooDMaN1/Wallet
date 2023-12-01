using TMPro;

public class WalletView : AWalletView
{
    public TextMeshProUGUI _text;

    public WalletView(TextMeshProUGUI text)
    {
        _text = text;
    }

    public override void ChangeCoinsTo(int value)
    {
        _text.text = value.ToString();
    }
}
