using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawning : MonoBehaviour
{
    private GameObject Temp;
    public GameObject TrashPrefab;

    [SerializeField]
    private GameObject GM;
    //public Animation Animation;

    [SerializeField]
    private float Spawn_Timer;
    private float timepassed = 0;
    private Timer GM_Timer;

    void Start ()
    {
       GM_Timer = GM.GetComponent<Timer>();
	}
	
	void Update ()
    {
        if (timepassed < Spawn_Timer)
        {
            timepassed += Time.deltaTime;
        }
        else if (timepassed >= Spawn_Timer)
        {
            timepassed = 0;
            SpawnObject(TrashPrefab, 0);

            //time - timepassed / 2
            if (GM_Timer.Time < 10)
            {

            }
            else if (Spawn_Timer > 0.5f)
            {
                Spawn_Timer = ( Spawn_Timer - (GM_Timer.Time * 0.0005f));
                Debug.Log(Spawn_Timer);
            }
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
