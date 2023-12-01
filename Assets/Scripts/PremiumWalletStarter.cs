using TMPro;
using UnityEngine;

public class PremiumWalletStarter : AWalletStarter
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void CreateWalletModel()
    {
        if (PremiumWalletModel.Instance == null)
            _model = new PremiumWalletModel();
    }

    protected override void CreateWalletView()
    {
        _view = new WalletView(_text);
    }
}
