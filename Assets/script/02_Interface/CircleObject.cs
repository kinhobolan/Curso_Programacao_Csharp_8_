using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleObject : MonoBehaviour
{
    public void Dano () {

        this.GetComponent<SpriteRenderer> ().color = Color.black;
        
    }
}
