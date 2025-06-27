using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{

    public List<PersistentScore> objectsToSave;
    void OnEnable()
    {
        foreach (PersistentScore item in objectsToSave)
        {
            item.Load();
        }
    }

    void OnDisable()
    {
        foreach (PersistentScore item in objectsToSave)
        {
            item.Save();
        }
    }
}
