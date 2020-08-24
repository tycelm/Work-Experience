using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarderSameLevelDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public GameObject checker;
    public GameObject Camera2;
    public GameObject Enemy;
    [SerializeField] private Image customImage;
    public SkillCheckController skillCheck;
    bool wantIn;


    void Update()
    {
        //skillCheck = checker.GetComponent<SkillCheckController>();
        if(wantIn)
            Check();
    }
        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetKeyDown("space"))
                {
                    customImage.enabled = false;
                    checker.SetActive(true);
                    Camera2.SetActive(true);
                    wantIn = true;
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetKeyDown("space"))
                {
                    customImage.enabled = false;
                    checker.SetActive(true);
                    Camera2.SetActive(true);
                    wantIn = true;
                }
            }
        }

        void OnTriggerExit2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = false;
            }
        }

        void Check()
        {
            
            if(skillCheck.gotValue == true)
            {
            if(skillCheck.passed)
            {
                player.transform.position = target.transform.position;
            }
            skillCheck.gotValue = false;
            checker.SetActive(false);
            }
        }
         
}
