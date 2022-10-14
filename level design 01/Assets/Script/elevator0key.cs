using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator0key : MonoBehaviour
{
    public Animator aa;
    public bool isClosed = true;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
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