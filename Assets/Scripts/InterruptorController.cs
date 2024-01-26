using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorController : MonoBehaviour
{
     public PlataformaMovil plataformaMovil;
    public PlataformaMovil plataformaMovil2;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            plataformaMovil.enabled = !plataformaMovil.enabled;
            plataformaMovil2.enabled = !plataformaMovil.enabled;
        }
    }
}

