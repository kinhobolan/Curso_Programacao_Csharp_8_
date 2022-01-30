using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class PopUp : MonoBehaviour {

  

    public GameObject panelPopUp;
    
       

    private void OnEnable () {

        CustomEvents.SendTextEvent += UpdateText;
    }

   

    private void OnDisable () {

        CustomEvents.SendTextEvent -= UpdateText;

    }

    private void UpdateText (string info) {

        StopAllCoroutines ();
        panelPopUp.SetActive (true);
        panelPopUp.GetComponentInChildren<TextMeshProUGUI> ().text  = info;
        StartCoroutine("CountDown");
                        
    }

    private IEnumerator CountDown () {

        yield return new WaitForSeconds (2);
        panelPopUp.SetActive (false);
    }


}
