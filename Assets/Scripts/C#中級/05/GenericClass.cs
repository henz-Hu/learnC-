using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T>//這是範型類
{
    T item;
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }

}
