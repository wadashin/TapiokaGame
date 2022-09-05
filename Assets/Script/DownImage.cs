using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownImage : MonoBehaviour
{
    [SerializeField] GameObject _downImage;
    static GameObject _useDownImage;

    private void Awake()
    {
        _useDownImage = _downImage;
    }

    public void CreateDown()
    {
        GameObject cloneObject = Instantiate(_useDownImage,new Vector2(240 + Random.Range(-140, 140), 400 + +Random.Range(-110, 110)), Quaternion.identity, this.transform);
        //cloneObject.transform.parent = this.transform;
    }
}
