using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Agreement : MonoBehaviour
{
    public GameObject sadge;
    public Animator anim;
    public Image blac;
    // Start is called before the first frame update
    public void Yes()
    {
        StartCoroutine("NextLevel");
    }

    public void No()
    {
        sadge.SetActive(true);
        StartCoroutine("NextLevel");
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blac.color.a == 1);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
