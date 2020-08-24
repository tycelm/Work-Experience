using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPath : MonoBehaviour
{
    public PatrolPath newOne;
    public GameObject enemy;
    private AIController host;


    void Start()
    {
        host = enemy.GetComponent<AIController>();
    }


    void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                host.patrol = newOne;
                //invisible unitl reached
                
            }
        }

}
