using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    [SerializeField] Transform _objectToFollow; 
    Vector3 _objectOffset;

    private void Awake()
    {
        _objectOffset = this.transform.position - _objectToFollow.position;
    }

    private void LateUpdate()
    {
        this.transform.position = _objectToFollow.position + _objectOffset;
    }
}
