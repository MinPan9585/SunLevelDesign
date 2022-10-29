using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door4key1 : MonoBehaviour
{
    public bool Key1IsPressed = false;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Key1IsPressed = true;
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
