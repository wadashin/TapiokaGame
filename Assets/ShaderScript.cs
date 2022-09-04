using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{

    private Material material;

    void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;
        //最初の色を青に設定
        material.SetColor("_BeforeColor", new Color(0, 0, 1f, 1f));
        material.SetFloat("_BeforeColorAmount", 1f);
        //赤に変更、下のコードは実装するタイミングで記述する
        //今回は実行と同時に色を変える
        StartCoroutine(ChangeColor(new Color(1f, 0, 0, 1f)));

    }

    public IEnumerator ChangeColor(Color _color)
    {
        material.SetColor("_AfterColor", _color);

        while (material.GetFloat("_BeforeColorAmount") > -1f)
        {
            material.SetFloat("_BeforeColorAmount", material.GetFloat("_BeforeColorAmount") - 0.01f);
            yield return new WaitForSeconds(0.01f);
        }
    }

}