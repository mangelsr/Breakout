using TMPro;
using UnityEngine;

public class ControlTypeDropdown : MonoBehaviour
{
    [SerializeField] Settings settings;
    TMP_Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.value = (int)settings.controlType;
        dropdown.onValueChanged.AddListener(
            delegate { settings.ChangeControlType(dropdown.value); }
        );
    }
}
