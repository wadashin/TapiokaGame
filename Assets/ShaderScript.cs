using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{

    private Material material;

    void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;
        //�ŏ��̐F��ɐݒ�
        material.SetColor("_BeforeColor", new Color(0, 0, 1f, 1f));
        material.SetFloat("_BeforeColorAmount", 1f);
        //�ԂɕύX�A���̃R�[�h�͎�������^�C�~���O�ŋL�q����
        //����͎��s�Ɠ����ɐF��ς���
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