using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    public Transform planet;
    public float orbitSpeed = 50f;

    void Update()
    {
        OrbitPlanet();
    }

    void OrbitPlanet()
    {
        transform.RotateAround(planet.position, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}
