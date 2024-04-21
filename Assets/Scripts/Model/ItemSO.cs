using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject{
    [field: SerializeField]

    public bool IsStackeable {get; set;}

    public int ID => GetInstanceID();

    [field: SerializeField]
    public int MaxStackSize {get; set;} = 1;
}
