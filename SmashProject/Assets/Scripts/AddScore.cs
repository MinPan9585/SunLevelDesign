using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddScore : MonoBehaviour
{
    void Start()
    {
    }

    void AddTenScore()
    {
        ScoreManager.instance.score += 10;
        ScoreManager.instance.scoreText.SetText(Convert.ToString(ScoreManager.instance.score));

        Debug.Log(ScoreManager.instance.score);
    }
}
