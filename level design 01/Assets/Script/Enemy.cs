using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            this.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject, 5);
        }
    }
}
