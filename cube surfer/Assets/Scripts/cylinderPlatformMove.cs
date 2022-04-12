using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderPlatformMove : MonoBehaviour
{

   public float donmeHiz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * donmeHiz*Time.deltaTime);
    }
}
