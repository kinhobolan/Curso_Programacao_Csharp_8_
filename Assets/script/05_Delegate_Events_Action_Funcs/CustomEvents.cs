using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEvents{


    public delegate void SendTextToPopUp(string info);
    public static event SendTextToPopUp SendTextEvent;


    public void DispatchTextToPopUpEvent (string infoEvt) {

        SendTextEvent?.Invoke (infoEvt);
        
    }


  

}
