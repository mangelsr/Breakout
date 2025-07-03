using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] GameObject gameOverMenu;
    List<GameObject> lives = new List<GameObject>();
    Ball ballScript;

    void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            lives.Add(child.gameObject);
        }
    }

    public void RemoveLive()
    {
        int lastIndex = lives.Count - 1;
        GameObject objectToDelete = lives[lastIndex];
        Destroy(objectToDelete);
        lives.RemoveAt(lastIndex);

        if (lives.Count <= 0)
        {
            gameOverMenu.SetActive(true);
            return;
        }

        GameObject ball = Instantiate(ballPrefab);
        ballScript = ball.GetComponent<Ball>();
        ballScript.ballDestroyed.AddListener(RemoveLive);

        Debug.Log($"Lives remaining: {lives.Count}");
    }

}
