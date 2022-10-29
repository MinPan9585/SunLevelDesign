using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door4key3 : MonoBehaviour
{
    public Animator aa;
    public door4key2 key;
    public bool isClosed = true;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && key.Key2IsPressed == true)
        {
            if (isClosed == true)
            {
                aa.SetTrigger("Open");
                isClosed = false;
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            else
            {
                aa.SetTrigger("Close");
                isClosed = true;
            }
        }
    }

}
