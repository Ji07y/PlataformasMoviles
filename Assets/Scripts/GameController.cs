using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI textoPerdiste;
    public PlataformaMovil plataformaMovil;
    public PlataformaMovil plataformaMovil2;
    void Start()
    {
        textoPerdiste.enabled = false;
        plataformaMovil.enabled = false;
        plataformaMovil2.enabled = false;
    }
     
}
