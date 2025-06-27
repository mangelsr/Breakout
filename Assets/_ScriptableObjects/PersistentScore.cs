using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PersistentScore : ScriptableObject
{
    public void Save(string fileName = null)
    {
        var binaryFormatter = new BinaryFormatter();
        var file = File.Create(GetRoute(fileName));
        var json = JsonUtility.ToJson(this);

        binaryFormatter.Serialize(file, json);
        file.Close();
    }

    public virtual void Load(string fileName = null)
    {
        if (File.Exists(GetRoute(fileName)))
        {
            var binaryFormatter = new BinaryFormatter();
            var file = File.Open(GetRoute(fileName), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)binaryFormatter.Deserialize(file), this);
            file.Close();
        }
    }

    public string GetRoute(string fileName = null)
    {
        var completeFileName = string.IsNullOrEmpty(fileName) ? name : fileName;
        return string.Format("{0}/{1}.dat", Application.persistentDataPath, completeFileName);
    }
}
