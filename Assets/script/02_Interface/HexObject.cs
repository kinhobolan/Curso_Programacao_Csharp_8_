using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexObject : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision) {


        IDanificavel forma = collision.GetComponent<IDanificavel> ();
        // A interrogação previni se o objeto for nulo para que
        // o Metedodo não seja chamado;
        forma?.Dano ();

        if(collision.TryGetComponent (out IDanificavel d)){
            d.Dano ();
        }


        // Tentat pegar o componente
        if (collision.gameObject.TryGetComponent (out SpecialFx sfx)) {

            sfx.OnRelease ();

        }

        
       

    }


    private void Update () {

        if (Input.GetKeyDown (KeyCode.D)) {


            this.gameObject.transform.Translate (1,0,0);
        }
        if (Input.GetKeyDown (KeyCode.A)) {

          
            this.gameObject.transform.Translate (-1,0,0);
        }
    }
}
