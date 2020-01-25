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
                slider.value = settings.bloom.GetValue();
                slider.onValueChanged.AddListener(OnValueChangedBloom);
                break;
            case "Kittens":
                slider.value = settings.bloom.GetValue();
                slider.onValueChanged.AddListener(OnValueChangedKittens);
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

    public void OnValueChangedKittens(float newValue)
    {
        settings.cats.SetValue((int)newValue);
    }
}
