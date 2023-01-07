using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddScore : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("AddTenScore", 1f, 1f);
    }

    void AddTenScore()
    {
        ScoreManager.instance.score += 10;
        ScoreManager.instance.scoreText.SetText(Convert.ToString(ScoreManager.instance.score));

        Debug.Log(ScoreManager.instance.score);
    }
}
