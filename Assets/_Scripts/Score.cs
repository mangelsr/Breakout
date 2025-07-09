using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    Transform highScoreTransform;
    Transform currentScoreTransform;
    TMP_Text highScoreText;
    TMP_Text currentScoreText;
    [SerializeField] HighScore highScoreSO;

    void Start()
    {
        currentScoreTransform = GameObject.Find("ScoreText").transform;
        highScoreTransform = GameObject.Find("HighScoreText").transform;

        currentScoreText = currentScoreTransform.GetComponent<TMP_Text>();
        highScoreText = highScoreTransform.GetComponent<TMP_Text>();

        highScoreSO.Load();
        highScoreSO.score = 0;
        highScoreText.text = $"High Score: {highScoreSO.highScore}";
    }

    void Update()
    {
        currentScoreText.text = $"Score: {highScoreSO.score}";
        if (highScoreSO.score > highScoreSO.highScore)
        {
            highScoreSO.highScore = highScoreSO.score;
            highScoreText.text = $"High Score: {highScoreSO.highScore}";
            highScoreSO.Save();
        }
    }

    public void IncreaseScore(int score)
    {
        highScoreSO.score += score;
    }

    public void DecreaseScoreByPercentage(int percentage)
    {
        int pointsToDecrease = highScoreSO.score * percentage / 100;
        highScoreSO.score -= pointsToDecrease;
    }
}
