using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjectTransform : MonoBehaviour
{
    public GameObject MyCube;
    public Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {
        MyCube.transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
