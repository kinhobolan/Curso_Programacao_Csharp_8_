using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armaduras: IProduto {

    public string nome { get; set; }

    public void Usar () {

        Debug.Log ($"Usando {nome}");
    }

    public void Vestido () {

        Debug.Log ($"Vestido {nome}");
    }

}


