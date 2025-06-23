using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    bool isGameStarted = false;

    void Start()
    {
        Transform playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 initialPosition = playerTransform.position;
        initialPosition.y += 2;
        transform.position = initialPosition;
        transform.SetParent(playerTransform);
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetButton("Submit")) && !isGameStarted)
        {
            isGameStarted = true;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = speed * Vector3.up;
        }
    }
}
