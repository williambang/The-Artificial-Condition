using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Manager : MonoBehaviour
{
    public List<GameObject> sets = new List<GameObject>();

    void Awake() {
        AddChildren();
    }

    public void AddChildren() {
        foreach (Transform child in transform)
            {
                sets.Add(child.gameObject);
            }
    }

}  
