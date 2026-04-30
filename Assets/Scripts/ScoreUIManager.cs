using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "Puntaje:" + score.ToString();
    }
    public void AddPointAndUptateScore()
    {
        score++;
        txtScore.text = "Puntaje:" + score.ToString();
        if(score >= 3 )
        {
            txtScore.text = "Ganaste";

        }

    }
}
