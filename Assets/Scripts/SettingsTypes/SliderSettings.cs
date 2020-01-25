using UnityEngine;
using UnityEngine.UI;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class SliderSettings : MonoBehaviour
{
    [SerializeField]
    string settingName = default;
    private Settings settings;
    private Slider slider;

    private void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;

        slider = GetComponent<Slider>();
        switch (settingName)
        {
            case "Bloom":
                slider.onValueChanged.AddListener(OnValueChangedBloom);
                break;
            default:
                Debug.LogError("Wrong name for slider: " + settingName);
                break;
        }
        
    }

    public void OnValueChangedBloom(float newValue)
    {
        settings.bloom.SetValue(newValue);
    }
}
