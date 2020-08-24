using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject Flashlight;
    public int outOf;
    int got;
    void Start()
    {
        InvokeRepeating("Blink", 0, 0.5f);
    }

    void Blink()
    {
        got = Random.Range(0, outOf);

        if(got == 4)
        {
            Flashlight.SetActive(false);
            Invoke("BackOn", 0.5f);
            Debug.Log("Blink");
        }
    }

    void BackOn()
    {
        Flashlight.SetActive(true);
    }
}
