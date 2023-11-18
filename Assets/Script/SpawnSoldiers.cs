using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnSoldiers : MonoBehaviour
{
    [SerializeField] private GameObject _soldierPrefab;

    private void Update()
    {
        
    }


    public void SpawnSoldier()
    {
        int random = Random.Range(-3, 3);
        Instantiate(_soldierPrefab, new Vector3(transform.position.x,random,transform.position.z), Quaternion.identity);
    }
}
