using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawning : MonoBehaviour
{
    private GameObject Temp;
    public GameObject TrashPrefab;
    //public Animation Animation;

    [SerializeField]
    private int Timer;
    private float timepassed = 0;

    private float GameTimePassed = 0;

	void Start ()
    {
        
	}
	
	void Update ()
    {
        GameTimePassed += Time.deltaTime;

        if (timepassed < Timer)
        {
            timepassed += Time.deltaTime;
        }
        else if (timepassed >= Timer)
        {
            timepassed = 0;
            SpawnObject(TrashPrefab, 0);

            //time - timepassed / 2
            Timer = (int)Random.Range(10, Mathf.Floor(((float)Timer - timepassed) / 2f));
        }
	}

    public void SpawnObject( GameObject Item, int Amount )
    {
        for (int i = 0; i <= Amount; i++)
        {
            Temp = Instantiate(Item, new Vector3(Random.Range(-7f, 7f),0, (Random.Range(-4f, 5f))), Quaternion.identity);
            //Animation TempAnimator = Temp.GetComponent<Animation>();
            //TempAnimator = Animation;
        }
    }
}
