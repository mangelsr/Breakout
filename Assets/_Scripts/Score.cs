using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    Transform highScoreTransform;
    Transform currentScoreTransform;
    TMP_Text highScoreText;
    TMP_Text currentScoreText;
    [SerializeField] HighScore highScoreSO;
    private const string HIGH_SCORE_KEY = "HIGH_SCORE";

    void Start()
    {
        currentScoreTransform = GameObject.Find("ScoreText").transform;
        highScoreTransform = GameObject.Find("HighScoreText").transform;

        currentScoreText = currentScoreTransform.GetComponent<TMP_Text>();
        highScoreText = highScoreTransform.GetComponent<TMP_Text>();


        // We can use PlayerPrefs to store persistent data across gameplay sessions
        // Note, this only stores Int, Float and String data types
        // And it's not encrypted
        // More details on https://docs.unity3d.com/ScriptReference/PlayerPrefs.html 

        // if (PlayerPrefs.HasKey(HIGH_SCORE_KEY))
        // {
        //     highScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY);
        //     highScoreText.text = $"High Score: {highScore}";
        // }

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
            // PlayerPrefs.SetInt(HIGH_SCORE_KEY, highScore);
        }
    }

    public void IncreaseScore(int score)
    {
        highScoreSO.score += score;
    }
}
