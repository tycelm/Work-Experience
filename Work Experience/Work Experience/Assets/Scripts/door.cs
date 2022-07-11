using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    [SerializeField] private Image customImage;
    public Animator anim;
    public Image blac;
    

        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetButtonDown("Space"))
                {
                    StartCoroutine("Leave");
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetButtonDown("Space"))
                {
                    StartCoroutine("Leave");
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

    IEnumerator Leave()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blac.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
