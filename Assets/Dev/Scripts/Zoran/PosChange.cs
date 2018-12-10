using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum positionChange
{
    x_positive,
    x_minus,
    y_positive,
    y_minus,
    z_positive,
    z_minus
}

public class PosChange : MonoBehaviour
{
    public positionChange positionchange;

    private Transform moveableObject;

    private Vector3 tempPos;

    void Start()
    {
        moveableObject = this.transform;
        tempPos = moveableObject.position;
    }

    void Update()
    {
        //De positie van het object kan een bepaalde kant op gaan 
        if (positionchange == positionChange.x_positive)
            tempPos.x += GM.trash;
            moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);
        if (positionchange == positionChange.x_minus)
            tempPos.x -= GM.trash;
        moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);

        if (positionchange == positionChange.y_positive)
            tempPos.y += GM.trash;
            moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);
        if (positionchange == positionChange.y_minus)
            tempPos.y -= GM.trash;
        moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);

        if (positionchange == positionChange.z_positive)
            tempPos.z += GM.trash;
            moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);
        if (positionchange == positionChange.z_minus)
            tempPos.z -= GM.trash;
        moveableObject.transform.position = new Vector3(tempPos.x, tempPos.y, tempPos.z);
    }
}
