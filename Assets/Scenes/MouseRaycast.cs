using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    private IRaycast _raycast;
    
    private void Update()
    {
        var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(mouseRay, out RaycastHit hit, 1000, 1 << 8))
        {
            _raycast = hit.collider.GetComponent<IRaycast>();
            _raycast?.OnRaycastEnter();
        }
        else
        {
            if (_raycast != null)
            {
                _raycast.OnRaycastExit();
                _raycast = null;
            }
        }
    }
}
