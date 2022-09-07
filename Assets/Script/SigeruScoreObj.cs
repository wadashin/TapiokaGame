using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SigeruScoreObj : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Digestion");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Digestion()
    {
        yield return new WaitForSecondsRealtime(6);
        Straw.Capacity--;
        Destroy(this.gameObject);
    }
}
