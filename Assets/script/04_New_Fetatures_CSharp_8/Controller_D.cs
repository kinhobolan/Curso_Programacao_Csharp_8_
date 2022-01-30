using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller_D : MonoBehaviour {



    void Start () {
        Debug.Log (VerificaTemperatura (25));
        Debug.Log (VerificaTemperatura (27.5f));
        Debug.Log (VerificaGenero ("masculino"));
        Debug.Log (VerificaGenero ("w"));
        NovoSistemaDeIndice ();
        NovoRange ();
      
        float n = 3.8548f;


        Debug.Log (DoMath (4,5,MathOperation.SOMAR));
        Debug.Log (DoMath (4,5,MathOperation.RAIZ_QUADRADA));


    }

    //Retorno da Condicional
    public string VerificaTemperatura (float celsius) => celsius > 26.5 ? "Quente" : "Agradável";

    public float VerificaGenero (string genero) => genero == "masculino" ? 1.5f : 2.4f;

    //Array 

    public void NovoSistemaDeIndice () {

        string[] nomes = { "Kinho","Joao","Pedro","Rafel","Jose","Gabriel","Mateus","Ronaldo","Ricardo" };

        Debug.Log (nomes[2]);

        // Com ^ conta de tras para frente
        Debug.Log (nomes[^2]);

        //Ultimo Elemento do Array
        Debug.Log (nomes[^1]);

        // Pega uma Fatia do Array

        string[] selecaoNomes = (nomes[1..4]);
        foreach (var item in selecaoNomes) {
            Debug.Log ($"Selecao{ item}");
        }

        // Pega todo o Array
        selecaoNomes = (nomes[0..^0]);
        foreach (var item in selecaoNomes) {
            Debug.Log ($"-> { item}");
        }

        // Foreach apenas para essa selecao
        foreach (var item in nomes[5..8]) {
            Debug.Log ($"|-> { item}");
        }



    }

    // Novo Sistema de Range

    public void NovoRange () {


        var rangeAtaque = 20..40;
        Debug.Log ($"Ataque {Random.Range (rangeAtaque.Start.Value,rangeAtaque.End.Value)}");


        int incio = 10;
        int fim = 20;
        var ataque = incio..fim;

        Debug.Log ($"Ataque {Random.Range (ataque.Start.Value,ataque.End.Value)}");
    }


    public void Falar () => Debug.Log ("Falando");


    //Novo Switch
    public static string RockPaperScissors (string first,string second)

    => (first, second) switch {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };


    public float DoMath(float a, float b, MathOperation mathOp) {

        float result = 0;

        result = mathOp switch {

            MathOperation.SOMAR => a + b,
            MathOperation.SUBTRAIR => a - b,
            MathOperation.MULTIPLICAR => a * b,
            MathOperation.DIVIDIR => a / b,
            _ => throw new System.Exception ("Esse enum não existe")

        };



        return result;
    }
  


}
