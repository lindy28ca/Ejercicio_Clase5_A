using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<Item, int> inventory = new Dictionary<Item, int>();

    public void Add(Item _item)
    {
        if (inventory.TryGetValue(_item, out int value)) //en caso intenten añadir uno solo que ya existe solo suma uno
            inventory[_item] = value + 1;
        else// En caso añade un item por primera vez
            inventory.Add(_item, 1);
    }
    public void Add(Item _item, TypeOfItem _typeOfItem)
    {
        _item.SetType(_typeOfItem);//cambiamos el tipo del item
        Add(_item);//añadimos un unico item
    }
    public void Add(Item _item, int quantity)
    {
        if (inventory.TryGetValue(_item, out int value))//añadimos uno que ya existe con una cantidad especifica
            inventory[_item] = value + quantity; //accedenis al key  y modificamos su value
        else
            inventory.Add(_item, quantity); //en caso no existe se añade la llave y la cantidad
    }
    public void Add(Item _item, TypeOfItem _typeOfItem, int _quantity)
    {
        _item.SetType(_typeOfItem);
        Add(_item, _quantity);
    }
    public void ShowAllItems()
    {
        foreach (var slot in inventory)
            Debug.Log("El item " + slot.Key.ItemName + " Con la cantidad " + slot.Value);
    }
}

