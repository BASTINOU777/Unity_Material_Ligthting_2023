using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour, IUsableObject
{
    // j'utilise l'instance pour r�cup�rer la fonction de changement de couleur
    public void UseObject() { ChangeColor(); }

    // fonction de changement de couleur de l'objet
    private void ChangeColor()
    {
        //je recup�re la couleur du mesh et lui donne une couleur bleue
        GetComponent<MeshRenderer>().material.SetColor("_BaseColor", Color.blue);
    }
}
