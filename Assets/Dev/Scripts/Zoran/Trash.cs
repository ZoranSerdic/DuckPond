using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private float TrashRemove = 2;

    public void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GM.TrashAmount -= TrashRemove;
        Debug.Log("ThrasAmount = " + GM.TrashAmount);
        Debug.Log("trash = " + GM.trash);

        Destroy(gameObject);
    }
}
