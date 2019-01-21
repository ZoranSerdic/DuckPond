using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBehavior : MonoBehaviour
{
    private int factorystate = 0;

    private GameObject GM;

    [SerializeField]
    GameObject MainStructure;
    [SerializeField]
    GameObject Chimney;
    
    private void expand()
    {
        switch (factorystate)
        {
            case 0:
                factorystate += 1;
                break;
            case 1:
                factorystate += 1;
                break;
            case 2:
                factorystate += 1;
                break;
            case 3:
                factorystate += 1;
                break;
            case 4:
                factorystate += 1;
                break;

        }
    }

	
}
