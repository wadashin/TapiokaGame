using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TapiokaBase : MonoBehaviour
{
    protected Transform strawpoint = null;

    public abstract void Absorption(Transform straw);

    public abstract void Swallow();
}
