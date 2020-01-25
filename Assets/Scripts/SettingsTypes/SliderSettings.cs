using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class SliderSettings : MonoBehaviour
{
    private Settings settings;
    private Slider slider;

    private void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;
        Debug.LogError(settings);

        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChanged);
    }

    public void OnValueChanged(float newValue)
    {
        settings.bloom.SetValue(newValue);
    }
}
