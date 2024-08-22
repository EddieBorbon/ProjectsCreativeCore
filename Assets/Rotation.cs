using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float velocidadRotacion = 10f; // Velocidad de rotación en grados por segundo
    private float rotacionX = -90f; // Comienza en -90 para simular el amanecer

    void Update()
    {
        // Incrementa la rotación en el eje X
        rotacionX += velocidadRotacion * Time.deltaTime;

        // Restringe la rotación entre -90 y 90 grados
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        // Aplica la rotación en el eje X
        transform.localRotation = Quaternion.Euler(rotacionX, 0, 0);

        // Activa o desactiva la luz dependiendo de su posición
        if (rotacionX < 0 || rotacionX > 180)
        {
            GetComponent<Light>().enabled = false; // Desactiva la luz cuando está por debajo del horizonte
        }
        else
        {
            GetComponent<Light>().enabled = true; // Activa la luz cuando está sobre el horizonte
        }
    }
}
