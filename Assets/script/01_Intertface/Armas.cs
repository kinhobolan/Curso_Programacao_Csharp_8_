using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : IProduto {

    public string nome { get; set; }

    public void Usar () {

        Debug.Log ($"Usando {nome}");
    }

    public void Carregar () {

        Debug.Log ($"Carregando {nome}");
    }



}
