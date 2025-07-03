using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksManager : MonoBehaviour
{
    [SerializeField] GameObject EndLevelMenu;

    void Update()
    {
        if (transform.childCount == 0)
        {
            EndLevelMenu.SetActive(true);
        }
    }
}
