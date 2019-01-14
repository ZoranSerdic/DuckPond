using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static float trash = 0f;
    public static float TrashAmount = 0f;
    
	void Update ()
    {
        //Kijk hoeveel objecten met de tag "Trash" er zijn en zet ze in een array
        GameObject[] TrashObjects = GameObject.FindGameObjectsWithTag("Trash");
        int numberOfTrash = TrashObjects.Length;

        if (numberOfTrash >= 9)
        {
            TrashAmount += 0.9f * Time.deltaTime;
            trash = 0.001f;
        }
        else if (numberOfTrash >= 6)
        {
            TrashAmount += 0.6f * Time.deltaTime;

            trash = 0.0007f;

            trash = 0.001f;
        }

        else if (numberOfTrash >= 3)
        {
            TrashAmount += 0.3f * Time.deltaTime;

            trash = 0.0005f;

            trash = 0.001f;

        }
        else //default
        {
            trash = 0.0002f;
        }

        //Shortcuts
        //Debug
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Number of Trash = " + numberOfTrash);
            Debug.Log("Amount of Trash in the Trash Bin = " + TrashBin.trashBinAmount);
            Debug.Log("Total Trash amount = " + GM.TrashAmount);
        }        

        //Make things go faster
        if (Input.GetKey(KeyCode.S))
        {
            trash = 0.25f;
        }
    }
}
