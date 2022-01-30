using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMotor  {
   
    string nome { get; }
    
    void Ligar () {

        Debug.Log ("Ligando Motor Generico");
    }
}
