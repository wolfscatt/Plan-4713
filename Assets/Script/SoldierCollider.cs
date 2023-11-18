using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyBase")
        {
            Destroy(gameObject);
        }
    }
}
