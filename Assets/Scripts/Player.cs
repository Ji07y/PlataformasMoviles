using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI textoPerdiste;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fuego"))
        {
            textoPerdiste.enabled = true;
            textoPerdiste.text = "¡Has Perdido!";
            Debug.Log("¡Has Perdido!");
        }
    }

}
