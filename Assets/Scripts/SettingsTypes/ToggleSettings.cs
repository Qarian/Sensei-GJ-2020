using UnityEngine;
using UnityEngine.UI;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

[RequireComponent(typeof(Toggle))]
public class ToggleSettings : MonoBehaviour
{
    [SerializeField]
    string settingName = default;
    private Settings settings;
    private Toggle slider;

    private void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;

        slider = GetComponent<Toggle>();
        switch (settingName)
        {
            case "Auto settings":
                slider.onValueChanged.AddListener(OnValueChangedAutoSettings);
                break;
            default:
                Debug.LogError("Wrong name for slider: " + settingName);
                break;
        }
    }

    public void OnValueChangedAutoSettings(bool newValue)
    {
        settings.autoSettings.SetValue(newValue);
    }
}
