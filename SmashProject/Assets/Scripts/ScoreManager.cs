using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public TMP_Text scoreText;

    void Start ()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
    }
}
