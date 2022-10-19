using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator2key : MonoBehaviour
{
    public Animator aa;
    public Elevator2PreKey key;
    public bool isClosed = true;




    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && key.preKeyIsPressed == true)
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
