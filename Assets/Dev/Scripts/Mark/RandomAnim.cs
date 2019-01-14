using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnim : MonoBehaviour
{

    private Animator m_Anim;

	// Use this for initialization
	void Start ()
    {
        m_Anim = GetComponent<Animator>();

        int i = Random.Range(1, 3);

        switch (i)
        {
            case 1:
                m_Anim.GetInteger(1);
                break;
            case 2:
                m_Anim.GetInteger(2);
                break;
            case 3:
                m_Anim.GetInteger(3);
                break;
            default:
                break;
        }
    }
	
	void Update ()
    {
		
	}
}
