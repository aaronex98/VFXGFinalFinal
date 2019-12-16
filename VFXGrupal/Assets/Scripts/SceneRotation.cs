using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRotation : MonoBehaviour
{
    public float speed;
    public Vector3 rotateVector;
     void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(rotateVector * Time.deltaTime * speed); 
    }
}
