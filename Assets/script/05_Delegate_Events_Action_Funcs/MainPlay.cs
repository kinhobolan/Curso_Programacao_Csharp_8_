using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlay : MonoBehaviour {

    private void OnTriggerEnter2D (Collider2D other) {


        IHit hit = other.GetComponent<IHit> ();

        hit?.OnHit ();
       

    }


    private void OnEnable () {
       

        GameInput.actionRight += MoveRight;
        GameInput.actionLeft += MoveLeft;

    }

    private void OnDisable () {

        GameInput.actionRight -= MoveRight;
        GameInput.actionLeft -= MoveLeft;
    }


    private void MoveRight () {

        this.gameObject.transform.Translate (1,0,0);
    }

    private void MoveLeft () {

        this.gameObject.transform.Translate (-1,0,0);
    }

}
