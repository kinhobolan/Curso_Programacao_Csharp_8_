using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_C : MonoBehaviour
{
    // Start is called before the first frame update
    void Start () {
        List<IMotor> listaVeiculos = AddVeiculos ();

        foreach (var item in listaVeiculos) {

            Debug.Log ($"Item: {item.nome} ");
            
            item.Ligar ();

        }
    }


    List<IMotor> AddVeiculos () {

        List<IMotor> lista = new List<IMotor> ();

        lista.Add (new Carro { nome = "Ferrari" });
        lista.Add (new Aviao { nome = "Boing 747" });
      

        return lista;
    }


}
