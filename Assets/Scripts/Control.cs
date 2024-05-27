using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Control : MonoBehaviour
{
    private TMP_Text scoreText;
    public int score;
    public float time;
    private float timeStart;

    void Start()
    {
        scoreText = FindObjectOfType<TMP_Text>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        scoreText.text = "score: " + score;
        if (time <= 0)
        {
            score += 1;
            time = timeStart;
        }
    }
}