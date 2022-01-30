using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduto {

    string nome { get; }

    void Usar ();

    void Melhorar () {

        Debug.Log ($"Melhorando {nome}");
    }
   



}
