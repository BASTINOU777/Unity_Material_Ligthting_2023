using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour, IUsableObject
{
    [SerializeField] private Light _light;
    [SerializeField] private MeshRenderer _lightEmissive;


    private void ToggleLight()
    {
        //si la ligth est active j'active l'�missive
        _light.enabled = !_light.enabled;
        if (_light.enabled)
        {
            _lightEmissive.material.EnableKeyword("_EMISSION");
        }
        //sinon je d�sactive l'�missive
        else
        {
            _lightEmissive.material.DisableKeyword("_EMISSION");
        }
    }

    public void UseObject()
    {

        ToggleLight();

    }
}
