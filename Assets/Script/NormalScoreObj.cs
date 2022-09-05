using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScoreObj : MonoBehaviour
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
        yield return new WaitForSecondsRealtime(5);
        Debug.Log(Straw.Capacity);
        Destroy(this.gameObject);
    }
}
