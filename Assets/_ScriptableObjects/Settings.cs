using UnityEngine;

public enum Difficulty
{
    Easy,
    Normal,
    Hard,
}

public enum ControlType
{
    Keyboard,
    Controller,
    Mouse,
}

[CreateAssetMenu(fileName = "Settings", menuName = "Tools/Settings", order = 1)]
public class Settings : PersistentObject
{
    public float ballSpeed = 30;
    public Difficulty levelDifficulty = Difficulty.Easy;

    public ControlType controlType = ControlType.Keyboard;

    public void ChangeSpeed(float newSpeed)
    {
        ballSpeed = newSpeed;
    }

    public void ChangeDifficulty(int newDifficulty)
    {
        levelDifficulty = (Difficulty)newDifficulty;
    }

    public void ChangeControlType(int newControlType)
    {
        controlType = (ControlType)newControlType;
    }
}
