using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class facetracking : MonoBehaviour
{
    [SerializeField] private ARFaceManager _arFaceManager;

    private void OnEnable()
    {
        _arFaceManager.facesChanged += OnfacesChanged;
    }

    private void OnDisable()
    {
        _arFaceManager.facesChanged -= OnfacesChanged;
    }

    private void OnfacesChanged(ARFacesChangedEventArgs obj)
    {
    }
}
