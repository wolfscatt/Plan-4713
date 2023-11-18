using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiersMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        SoldierMove();
    }

    private void SoldierMove()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
