using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    [SerializeField] private Transform _planet;
    [SerializeField] private float _orbitSpeed = 50f;

    void Update()
    {
        OrbitPlanet();
    }

    void OrbitPlanet()
    {
        transform.RotateAround(_planet.position, Vector3.forward, _orbitSpeed * Time.deltaTime);
    }
}
