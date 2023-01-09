using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tomato : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    { 
    }
    // Update is called once per frame
    void Update()
    {
    }

    private void OnDestroy()
    {
        ScoreManager.instance.score += points;
        ScoreManager.instance.scoreText.SetText(Convert.ToString(ScoreManager.instance.score));
    }
}
