using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int count = 5;
    public float radius = 5;
    
    void Start()
    {
        var angle = 360f / count;
        for (float i = 0; i < 360; i+=angle)
        {
            var x = radius * Mathf.Cos(i * Mathf.Deg2Rad);
            var y = radius * Mathf.Sin(i * Mathf.Deg2Rad);
            Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity, transform);     
        }
    }
}
