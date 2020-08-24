using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusCheck : MonoBehaviour
{
    public GameObject door;
    private SameLevelDoor theDoor;
    public GameObject enemy;
    bool entered;
    void Start()
    {
        theDoor = door.GetComponent<SameLevelDoor>();
    }

    void Update()
    {
        entered = theDoor.wentIn;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Enemy"))
            {
                if(entered)
                {
                    Invoke("TeleportEnemy", 3);
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Enemy"))
            {
                if(entered)
                {
                    Invoke("TeleportEnemy", 3);
                }
            }
        }

        void TeleportEnemy()
        {
            enemy.transform.position = theDoor.target.transform.position;
            theDoor.wentIn = false;
        }
}
