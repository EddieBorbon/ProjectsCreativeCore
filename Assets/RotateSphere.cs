using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Calcula la cantidad de rotación para este frame
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Aplica la rotación al objeto
        transform.Rotate(Vector3.up, rotationAmount);
    }
}
