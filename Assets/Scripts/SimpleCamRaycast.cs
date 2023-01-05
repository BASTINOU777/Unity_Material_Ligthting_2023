using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class SimpleCamRayscast : MonoBehaviour
{
    [SerializeField] private Image _reticule;

    private void Update()
    {
        UseTarget(FindUsableTarget());

    }
    //fonction pour ativer un objet au raycast hit
    private IUsableObject FindUsableTarget()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // si mon hit au collider recupère un objet  alors j'affiche la couleur en vert 
            if (hit.collider.GetComponent<IUsableObject>() != null)
            {
                _reticule.color = Color.green;
                return hit.collider.GetComponent<IUsableObject>();
            }
            // sinon la couleur sera blanche
            else
            {
                _reticule.color = Color.white;

            }
        }
        // sinon pas d'objet alors blanc 
        else
        {
            _reticule.color = Color.white;

        }
        return null;
    }

    private void UseTarget(IUsableObject usableObject)
    {
        if (Input.GetKeyDown(KeyCode.U) && usableObject != null)
        {
            usableObject.UseObject();
        }

    }
}
