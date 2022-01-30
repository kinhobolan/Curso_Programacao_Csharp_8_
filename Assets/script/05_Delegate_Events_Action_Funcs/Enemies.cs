using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Enemies : MonoBehaviour, IHit {


    private CustomEvents evt;
 


    public void OnHit () {

        OnDie ();
    }

    public void OnDie () {

        

        evt = new CustomEvents ();
        evt.DispatchTextToPopUpEvent ($"{this.gameObject.name} has died !");
        Destroy (this.gameObject);



    }

   
}
