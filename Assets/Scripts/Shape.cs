using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private int m_clickCnt = 0;

    // ENCAPSULATION
    public int ClickCnt
    {
        get
        {
            return m_clickCnt;
        }
        set
        {
           if (value >= 0)
            {
                m_clickCnt = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        m_clickCnt++;
        ShowInfo();   
    }

    private void ShowInfo()
    {
        string showTest = $"{DisplayText()} clicked {m_clickCnt} times.";
        GameManager.Instance.ShowShapeInfo(showTest);
    }

    // ABSTRACTION 
    public virtual string DisplayText()
    {
        // do nothing
        return "BaseShape";
    }
}
