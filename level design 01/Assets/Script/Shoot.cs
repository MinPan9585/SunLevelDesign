using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public Rigidbody rb;
    public Transform camTrans;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(new Vector3(camTrans.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0)*bulletSpeed);
        }
        
    }
}
