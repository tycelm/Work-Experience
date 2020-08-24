using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public PatrolPath patrol;
    public GameObject target;
    public GameObject checker;
    EnemyAI path;
    LOSS loss;
    Vector3 pos;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<EnemyAI>();
        loss = GetComponent<LOSS>();
        pos = target.transform.position;
        InvokeRepeating("Check", 0, 4f);
    }
    void Check()
    {
        if(index == patrol.Waypoints.Length)
        {
            index = 0;
        }

        if(loss.isAgro)
        {
            path.enabled = false;
        }
        else
        {
            path.enabled = true;

            // if(skillCheck.passed == false)
            //     {
            //         pos.x = checker.transform.position.x;
            //         pos.y = checker.transform.position.y;
            //         if(path.reachedEndOfPath == true)
            //         {
            //             Debug.Log("Turned off");
            //             theSkillCheck.SetActive(false);
            //         }
            //         else
            //         {
            //             return;
            //         }
            //     }

            if(path.reachedEndOfPath)
            {
                pos.x = float.Parse(patrol.Waypoints[index].x);
                pos.y = float.Parse(patrol.Waypoints[index].y);
                target.transform.position = pos;
                Debug.Log("Made it");
                index++;
                // no idea why it keeps jumping everywhere
            }
        }
    }

    
}
