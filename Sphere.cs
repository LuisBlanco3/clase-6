using UnityEngine;

public class EarthMoonSimulation : MonoBehaviour
{
    public Transform earth;  // Asigna el objeto que representa la Tierra
    public Transform moon;   // Asigna el objeto que representa la Luna
    public float earthRotationSpeed = 5f;  // Velocidad de rotaci�n de la Tierra
    public float orbitSpeed = 10f;  // Velocidad de la �rbita lunar
    public float orbitRadius = 2f;  // Radio de la �rbita

    void Update()
    {
        if (earth != null)
        {
            // Rotaci�n de la Tierra sobre su propio eje
            earth.Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);
        }

        if (earth != null && moon != null)
        {
            // La Luna orbita alrededor de la Tierra
            moon.RotateAround(earth.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}