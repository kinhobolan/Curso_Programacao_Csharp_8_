using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : IMotor {

    public string nome { get; set; }

    public void Ligar () {

        Debug.Log ($"Ligando Carro {nome}");
        

    }
}
