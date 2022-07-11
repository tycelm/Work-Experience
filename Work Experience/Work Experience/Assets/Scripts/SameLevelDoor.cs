using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SameLevelDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public bool wentIn;
    [SerializeField] private Image customImage;
    public Animator anim;
    public Image blac;
    

        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetKeyDown("space"))
                {
                    StartCoroutine("Transport");
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetKeyDown("space"))
                {
                    StartCoroutine("Transport");
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

    IEnumerator Transport()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blac.color.a == 1);
        player.transform.position = target.transform.position;
        anim.SetBool("Fade", false);
    }
    
}
