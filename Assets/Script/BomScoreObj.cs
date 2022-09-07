using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomScoreObj : MonoBehaviour
{
    [SerializeField] float radius = 10f;

    void Start()
    {
        StartCoroutine("Digestion");
    }

    void Explosion()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, radius);


        foreach (Collider2D hit in colliders)
        {
            NormalScoreObj tapi = hit.GetComponent<NormalScoreObj>();

            if (/*TryGetComponent(out NormalScoreObj */tapi)
            {
                tapi.Delete();
            }
        }

    }

    IEnumerator Digestion()
    {
        yield return new WaitForSecondsRealtime(2.2f);
        Explosion();
        Destroy(this.gameObject);
    }

}
