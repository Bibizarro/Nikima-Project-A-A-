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

    public static CameraController GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<CameraController>();
            }
            return instance;
        }
    }



    public void CameraShake()
    {
        an.SetTrigger("shake");
 
    }
}