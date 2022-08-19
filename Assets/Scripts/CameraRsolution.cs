using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRsolution : MonoBehaviour
{
    private float _defaultwidth;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        _defaultwidth = _camera.orthographicSize * _camera.aspect;
    }

    private void Update()
    {
        _camera.orthographicSize = _defaultwidth / _camera.aspect;
    }
}


