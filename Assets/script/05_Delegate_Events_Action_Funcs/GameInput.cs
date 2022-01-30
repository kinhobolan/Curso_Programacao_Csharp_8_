using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public  class GameInput : MonoBehaviour
{

    public static event Action actionRight;
    public static event Action actionLeft;
    

    private void Update () {

        if (Input.GetKeyDown (KeyCode.D)) {

            actionRight?.Invoke ();
        }

        if (Input.GetKeyDown (KeyCode.A)) {

            actionLeft?.Invoke ();
        }


    }


}
