using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _minXValue;
    [SerializeField] private float _maxXValue;
    [SerializeField] private float _orthoSize;
    [SerializeField] private float _zoomDuration;
    

    private Vector2 _mouseStart;
    
    private void Update()
    {
        CameraMove();
    }

    private void OnEnable()
    {
        SelectPlanet.OnCameraZoom += CameraZoom;
    }

    private void OnDisable()
    {
        SelectPlanet.OnCameraZoom -= CameraZoom;
    }

    private void CameraMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mouseStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 mouseEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = _mouseStart - mouseEnd;
            Vector3 newPosition = transform.position + new Vector3(direction.x, 0, 0);
            newPosition.x = Mathf.Clamp(newPosition.x, _minXValue, _maxXValue);
            transform.position = newPosition;
        }
    }

    private void CameraZoom(Vector3 xPosition)
    {
        gameObject.transform.DOMove(xPosition, _zoomDuration)
            .OnComplete(() => Camera.main.DOOrthoSize(_orthoSize, 5f));
        
    }
}
