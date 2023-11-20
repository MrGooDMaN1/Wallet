using TMPro;
using UnityEngine;

public class WalletStarter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    protected void Awake()
    {
        CreateWalletModel();
    }

    protected void Start()
    {
        CreateWalletVP();
    }

    public void CreateWalletModel()
    {
        if(AWalletModel.Instance == null)
            new WalletModel();
    }

    public void CreateWalletVP()
    {
        AWalletView view = new WalletView(_text);
        new WalletPresenter(view, WalletModel.Instance);
    }
}
