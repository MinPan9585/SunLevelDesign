using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door4key2 : MonoBehaviour
{
    public door4key1 key;

    public bool Key2IsPressed = false;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" && key.Key1IsPressed == true)
        {
            Key2IsPressed = true;
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}