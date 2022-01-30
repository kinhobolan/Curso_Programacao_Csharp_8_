using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class SpecialFx : MonoBehaviour {

    public int powerLevel;
    public void OnRelease () {

        Debug.Log ($"Release the power level {powerLevel}");

    }
        
}
