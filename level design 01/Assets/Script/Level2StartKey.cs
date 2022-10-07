using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2StartKey : MonoBehaviour
{
    public Animator anim;

    private void OnCollisionEnter(Collision oth)
    {
        if (oth.gameObject.CompareTag("Bullet"))
        {
            anim.SetTrigger("Hit");
        }
    }
}
