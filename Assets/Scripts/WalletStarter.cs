using UnityEngine;

public class WalletStarter : MonoBehaviour
{
    [SerializeField] AWalletView _aWalletView;
    [SerializeField] AWalletModel _aWalletModel;

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
        new WalletPresenter(_aWalletView, _aWalletModel);
    }
}
