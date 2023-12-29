using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawn : MonoBehaviour
{

    public List<GameObject> shapes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnShape()
    {
        ClearCur();
        SpawnOne();
    }

    private void ClearCur()
    {
        GameObject[] cur = GameObject.FindGameObjectsWithTag("Shape");
        foreach (GameObject obj in cur)
        {
            Destroy(obj);
        }
    }

    private void SpawnOne()
    {
        if (shapes.Count <= 0) { return;  }
        int index = Random.Range(0, shapes.Count);
        GameObject shape = shapes[index];

        Quaternion rotation = Quaternion.Euler(
            Random.Range(0.0f, 360.0f),
            Random.Range(0.0f, 360.0f),
            Random.Range(0.0f, 360.0f));

        Instantiate(shape, Vector3.zero, rotation);
    }
}
