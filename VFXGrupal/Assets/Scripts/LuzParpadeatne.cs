using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzParpadeatne : MonoBehaviour
{
    public Light foco;
    public MeshRenderer luz;
    public Color colorOn;
    public Color colorOff;

    public float minTime;
    public float maxTime;
    void Start()
    {
        StartCoroutine(FocoParpadeando(minTime, maxTime));
    }

 

    public IEnumerator FocoParpadeando(float min, float max)
    {
        foco.enabled = !foco.enabled;
        if (foco.enabled)
        {
            Debug.Log("4");
            luz.sharedMaterial.SetFloat("_Intensidad", 1);
        }
        else
        {
            luz.GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_Intensidad", 0);

        }
        yield return new WaitForSeconds(Random.Range(min, max));
        StartCoroutine(FocoParpadeando(min, max));

        yield return null;
    }
}
