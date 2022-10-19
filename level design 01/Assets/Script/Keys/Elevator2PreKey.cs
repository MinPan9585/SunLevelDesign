using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator2PreKey : MonoBehaviour
{
    public bool preKeyIsPressed = false;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            preKeyIsPressed = true;
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
