using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[DefaultExecutionOrder(1000)]
public class UIHandler : MonoBehaviour, IShowShapeInfoInterface
{
    public TextMeshProUGUI showText;
    private void Awake()
    {
        GameManager.Instance.RegisterShapeInfoShow(this);
    }

    private void OnDestroy()
    {
        GameManager.Instance.UnregisterShapeInfoShow(this);
    }

    public void ShowShapeInfo(string info)
    {
        showText.text = info;
    }
}
