using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlanet : MonoBehaviour
{
    [SerializeField] private string _levelName;

    public static event Action<Vector3> OnCameraZoom;

    private void OnMouseDown()
    {
        OnCameraZoom?.Invoke(gameObject.transform.position);
        //LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(_levelName);
    }
}
