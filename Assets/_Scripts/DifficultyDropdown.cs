using TMPro;
using UnityEngine;

public class DifficultyDropdown : MonoBehaviour
{
    [SerializeField] Settings settings;
    TMP_Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.value = (int)settings.levelDifficulty;
        dropdown.onValueChanged.AddListener(
            delegate { settings.ChangeDifficulty(dropdown.value); }
        );
    }
}
