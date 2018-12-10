using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private float TrashRemove = 2;
    
    private void OnMouseDown()
    {
        GM.TrashAmount -= TrashRemove;

        TrashBin.trashBinAmount += 1;
        Destroy(gameObject);
    }
}
