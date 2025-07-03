using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{

    public List<PersistentObject> objectsToSave;
    void OnEnable()
    {
        foreach (PersistentObject item in objectsToSave)
        {
            item.Load();
        }
    }

    void OnDisable()
    {
        foreach (PersistentObject item in objectsToSave)
        {
            item.Save();
        }
    }
}
