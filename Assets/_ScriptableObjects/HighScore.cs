using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "Tools/HighScore", order = 0)]
public class HighScore : PersistentObject
{
    public int score = 0;
    public int highScore = 0;
}
