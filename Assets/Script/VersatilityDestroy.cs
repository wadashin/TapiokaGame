using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersatilityDestroy : MonoBehaviour
{
    public void Boom()
    {
        Destroy(transform.root.gameObject);
    }
}
