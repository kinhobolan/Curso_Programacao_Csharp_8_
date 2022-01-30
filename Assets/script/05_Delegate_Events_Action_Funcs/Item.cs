using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour, IHit {

    public int itemValue;
    public static event Action<string> eventCollectItem;
    private CustomEvents evt;



    private void OnEnable () {

       
    }



    private void OnDisable () {

        

    }


    public void OnHit () {

        if (Controller_E.instance.AddItem (itemValue)) {

            RemoveItem ();
        }
            

        
    }


    private void RemoveItem () {

        evt = new CustomEvents ();
        evt.DispatchTextToPopUpEvent ($"{this.gameObject.name} collected: {itemValue}");
        Destroy (this.gameObject);

    }


}
