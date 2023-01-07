using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tomato : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "chuizi")
    //    {
    //        ScoreManager.instance.score += 10;
    //        ScoreManager.instance.scoreText.SetText(Convert.ToString(ScoreManager.instance.score));
    //    }
    //}

    private void OnDestroy()
    {
        ScoreManager.instance.score += 10;
        ScoreManager.instance.scoreText.SetText(Convert.ToString(ScoreManager.instance.score));
    }
}
