using UnityEngine;
using System.Collections;

public class Vibration : MonoBehaviour
{

    public static void Vibrate()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
      Handheld.Vibrate();
#endif
    }
}