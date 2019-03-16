using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private Text scoreText;
    public  int allScore=0;
    // Start is called before the first frame update
    void Start()
    {
        initGame();

    }

    // Update is called once per frame
    void Update()
    {
        updateScore();
    }
    void initGame()
    {
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        updateScore();
    }
    void updateScore()
    {
        scoreText.text = "score:" + allScore;
    }
    
}
