using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObjBase : MonoBehaviour
{
    // Start is called before the first frame update
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
        Destroy(this.gameObject);
    }
}
