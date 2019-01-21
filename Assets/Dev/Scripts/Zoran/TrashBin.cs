using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashBin : MonoBehaviour
{
    public TextMeshProUGUI text;

    public static float trashBinAmount = 0f;
    public float totalTrashAllowed = 4f;

    private float TrashRemove = 2;
    private float trashTotal;

    void Update ()
    {
        //ui score update
        text.text = "" + trashTotal;

		if (trashBinAmount >= totalTrashAllowed)
        {
            Debug.Log("Trash Bin is overflowing! \n All the Trash that was in the Trash Bin is now back in the water.");
            trashBinAmount = 0;
            //spawn x trashBinAmount in water
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trash"))
        {
            GM.TrashAmount -= TrashRemove;
            trashBinAmount += 1;
            if (trashTotal == 0)
            {
                Timer.GameStarted = true;
            }
            trashTotal += 1;
            Destroy(other.gameObject);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Cleared the Trash Bin.");
        trashBinAmount = 0;
    }
}
