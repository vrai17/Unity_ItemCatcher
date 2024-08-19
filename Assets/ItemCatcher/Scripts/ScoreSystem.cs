using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;
    public TextMeshProUGUI ScoreText;
    public int ScoreCount = 0;

    private void Awake()
    {
        instance = this;
    }
    public void AddScore()
    {
        ScoreCount += 10;
        ScoreText.text = "Score: " + ScoreCount.ToString();
    }


}
