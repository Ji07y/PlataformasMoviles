using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public float velocidadMovimiento = 2f;
    public Transform puntoFinal; // Punto final hacia el cual se moverá la plataforma

    private Vector3 puntoInicio;
    private bool moviendoseHaciaFinal = true;

    void Start()
    {
        puntoInicio = transform.position;
    }

    void Update()
    {
        MoverPlataforma();
    }

    void MoverPlataforma()
    {
        float paso = velocidadMovimiento * Time.deltaTime;

        if (moviendoseHaciaFinal)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoFinal.position, paso);

            if (transform.position == puntoFinal.position)
            {
                moviendoseHaciaFinal = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoInicio, paso);

            if (transform.position == puntoInicio)
            {
                moviendoseHaciaFinal = true;
            }
        }
    }
}
