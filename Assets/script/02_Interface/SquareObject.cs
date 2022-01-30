using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareObject : MonoBehaviour, IDanificavel
{
 

    public void Dano () {

        this.GetComponent<SpriteRenderer> ().color = Color.red;
        Debug.Log ("Acessando SquareObject");
    }
   
}
