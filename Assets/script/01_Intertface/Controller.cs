using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Armas arma;
    private Armaduras armadura;

    void Start()
    {
        List<IProduto> listaProdutos = addProduto ();

        foreach (var item in listaProdutos) {

            Debug.Log ($"Item: {item.nome} ");
            item.Usar ();
            item.Melhorar ();


            if(item is Armas arma) {
                                
                arma.Carregar ();
            }
            if (item is Armaduras armadura) {

                armadura.Vestido ();
            }
               
           
        }

        
    }

    List<IProduto> addProduto () {

        List<IProduto> lista = new List<IProduto> ();

        lista.Add(new Armas     { nome = "Espada" });
        lista.Add(new Armas     { nome = "Arco" } );
        lista.Add (new Armaduras { nome = "Colete" } );
        lista.Add (new Armaduras { nome = "Capacete" });


        return lista;
    }
   
   
}
