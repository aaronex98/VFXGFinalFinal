using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPropsManager : MonoBehaviour
{
    private List<Rigidbody> props;
    public float maxForce;
    public float minForce;
    void Start()
    {
        Rigidbody[] chilren = GetComponentsInChildren<Rigidbody>();
         foreach(Rigidbody r in chilren)
        {

            r.AddTorque(new Vector3(Random.Range(minForce, maxForce), Random.Range(minForce, maxForce), Random.Range(minForce, maxForce)), ForceMode.Force);


        }
    }

   
}
