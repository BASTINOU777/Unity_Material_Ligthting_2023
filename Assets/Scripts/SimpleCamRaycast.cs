using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;

public class SimpleCamRaycast : MonoBehaviour
{
    [SerializeField] private Image
    private void Update()
    {
       if (Physics.Raycast(transform.position.forward, out hit)) 
        {
            if (ProcessorArchitecture.collider.GetComponent<SwitchLight>()!= null)
            {
                _reticule color = color.green;
            }
            else
            {
                _reticule color = color.white;
            }
            else
            {
                _reticule color = color.white;
            }
        }
    }
}
