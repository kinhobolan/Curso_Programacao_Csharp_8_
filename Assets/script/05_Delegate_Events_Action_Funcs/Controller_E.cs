using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controller_E : MonoBehaviour {

    
    [SerializeField] private ItemScriptable item;

    public static Controller_E instance;

    private void OnEnable () {

        instance = this;

    }

    public bool AddItem(int value) {

        return item.AddAmount (value);
               
    }



}
