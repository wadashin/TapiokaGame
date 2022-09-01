using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTapioka : TapiokaBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!strawpoint)
        {

        }
    }


    public override void Absorption(Transform straw)
    {
        strawpoint = straw;
    }
}
