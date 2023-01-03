using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public Light ligthBulb = null;
    
    void Start()
    {
        
    }

   
    void Update()
    {

        void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ellen")
        {
            ligthBulb.enabled = true;
        }
        else if (other.name == "Ellen")
        {
            ligthBulb.enabled = false;
        }
    }
}
}
//à sortir de l'update si fonctionne pas 