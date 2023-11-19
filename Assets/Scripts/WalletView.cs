using TMPro;
using UnityEngine;

public class WalletView : AWalletView
{
    public WalletView(TextMeshProUGUI textMesh) : base(textMesh) { }
    public override void ChangeCoinsTo(int coins)
    {
        _textMesh.text = coins.ToString();
        base.ChangeCoinsTo(coins);
    }
}
