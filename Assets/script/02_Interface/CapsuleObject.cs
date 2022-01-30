using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleObject : MonoBehaviour, IDanificavel
{
    public void Dano () {

        this.GetComponent<SpriteRenderer> ().color = Color.gray;

    }

}
