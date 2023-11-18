using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASpawn : MonoBehaviour
{
    [SerializeField] private GameObject _aPrefab;

    private Vector3 mousePos;
    private GameObject _a;
    private void OnMouseDown()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _a = Instantiate(_aPrefab, mousePos, Quaternion.identity);
    }

    private void Update()
    {
        if (_a != null && Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _a.transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }

        if (Input.GetMouseButtonUp(0) && _a != null)
        {
            float yPos = mousePos.y;
            _a.transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        }
    }
}
