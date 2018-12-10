using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public static float trashBinAmount = 0f;

    public float totalTrashAllowed = 4f;
    
	void Update ()
    {
		if (trashBinAmount >= totalTrashAllowed)
        {
            Debug.Log("Trash Bin is overflowing! " +
                "All the Trash that was in the Trash Bin is now back in the water.");
            trashBinAmount = 0;
            //spawn x trashBinAmount in water
        }
	}

    private void OnMouseDown()
    {
        Debug.Log("Cleared the Trash Bin.");
        trashBinAmount = 0;
    }
}
