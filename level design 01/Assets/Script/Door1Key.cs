using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Key : MonoBehaviour
{
    public Animator doorAnimator;
    public bool isClosed = true;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (isClosed == true)
            {
                doorAnimator.SetTrigger("Open");
                isClosed = false;
            }
            else
            {
                doorAnimator.SetTrigger("Close");
                isClosed = true;
            }
        }
    }
}

