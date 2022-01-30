using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem",menuName ="Item/MainItem" )]
public class ItemScriptable : ScriptableObject {

    [SerializeField] private string itemName;
    [SerializeField] private int amount;
    [SerializeField] private int amountLimit;

    public string Name { get => itemName; }
    public int Amount { get => amount;}

    public bool AddAmount(int value) {

        if (value + amount <= amountLimit) { amount += value; return true; }

        return false;
    }
    
}
