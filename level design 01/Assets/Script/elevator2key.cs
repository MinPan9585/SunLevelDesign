using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator2key : MonoBehaviour
{
    public Animator aa;
    public GameObject key;
    public bool isClosed = true;
    public bool isPressed;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            isPressed = true;
        }
    }


    private void OnCollisionEnter(Collision other)
            {
                 if (other.gameObject.tag == "Bullet"&& isPressed == true)
                 {
                      if (isClosed == true)
                      {
                       aa.SetTrigger("Open");
                       isClosed = false;
                      }
                      else
                      {
                      aa.SetTrigger("Close");
                      isClosed = true;
                       }
                 }
            }
 
}
