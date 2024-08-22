using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = 60f; // Duración de un día completo en segundos
    public Light sunLight; // La luz direccional que actúa como el sol

    private float rotationSpeed;

    void Start()
    {
        // Calcula la velocidad de rotación basada en la duración del día
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rota la luz direccional para simular el ciclo día/noche
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);

        // Ajusta la intensidad de la luz para simular amanecer y atardecer
       
       
    }
}
