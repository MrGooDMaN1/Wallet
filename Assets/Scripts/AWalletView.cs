using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class AWalletView : IView
{
    protected TextMeshProUGUI _textMesh;

    public AWalletView(TextMeshProUGUI textMesh)
    {
        this._textMesh = textMesh;
    }

    public virtual void ChangeCoinsTo(int coins) { }
}
