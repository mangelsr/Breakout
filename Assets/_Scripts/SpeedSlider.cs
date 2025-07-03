using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    [SerializeField] Settings settings;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = settings.ballSpeed;
        slider.onValueChanged.AddListener(
            delegate { ControlChanges(); }
        );
    }

    void ControlChanges()
    {
        settings.ChangeSpeed(slider.value);
    }

}
