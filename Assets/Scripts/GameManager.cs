using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShowShapeInfoInterface
{
    void ShowShapeInfo(string info);
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private List<IShowShapeInfoInterface> showShapeObjs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        showShapeObjs = new List<IShowShapeInfoInterface>();
        DontDestroyOnLoad(gameObject);
    }

    public void ShowShapeInfo(string info)
    {
        showShapeObjs.ForEach(delegate (IShowShapeInfoInterface obj)
        {
            obj.ShowShapeInfo(info);
        });
    }

    public void RegisterShapeInfoShow(IShowShapeInfoInterface obj)
    {
        if (showShapeObjs.Find(x => x == obj) != null)
        {
            return;
        }

        showShapeObjs.Add(obj);
    }

    public void UnregisterShapeInfoShow(IShowShapeInfoInterface obj)
    {
        showShapeObjs.Remove(obj);
    }
}
