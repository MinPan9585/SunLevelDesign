using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public Rigidbody rb;
    public Transform camTrans;
    public Transform shootPoint;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject bulletInstance = Instantiate(bullet, transform.position + new Vector3(0f,0.76f,0f), transform.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(shootPoint.forward*bulletSpeed);
        }
        
    }
}
