using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(score);
        UpdateScoreText();

    }
    void UpdateScoreText()
    {
        ScoreManager scoreManager = GetComponent<ScoreManager>();
        scoreText.text = "Score: " + scoreManager.score.ToString();
    }
}
