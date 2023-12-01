using TMPro;
using UnityEngine;

public class StandartWalletStarter : AWalletStarter
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void CreateWalletModel()
    {
        if (StandartWalletModel.Instance == null)
            _model = new StandartWalletModel();
    }

    protected override void CreateWalletView()
    {
        _view = new WalletView(_text);
    }
}
