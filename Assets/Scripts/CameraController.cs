using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Animator an;
    public static CameraController instance;
    void Start()
    {
        an = GetComponent<Animator>();
    }


    public void CameraShake()
    {
        an.SetTrigger("shake");
<<<<<<< HEAD
         Handheld.Vibrate();
 
=======
        Handheld.Vibrate();
>>>>>>> cf0a8a87b4d97d648c47c477ee0e61fe8a577875
    }
}