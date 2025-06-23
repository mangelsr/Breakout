using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] protected int resistance = 1;

    void Start()
    {

    }

    void Update()
    {
        if (resistance <= 0)
            Destroy(gameObject);
    }

    protected virtual void BounceBall()
    {

    }
}
