using System;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{
    public AK.Wwise.Switch material;
    public GameObject rightFoot;
    public GameObject leftFoot;
    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.name);
            material.SetValue(rightFoot);
            material.SetValue(leftFoot);
        }
    }
}
