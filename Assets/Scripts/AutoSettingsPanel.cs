using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class AutoSettingsPanel : MonoBehaviour
{
    Settings settings;

    void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;
        if (settings.autoSettings.GetValue() == false)
            gameObject.SetActive(false);
    }

    public void ClosePanel()
    {
        settings.resolution.SetValue(SenseiGameJam.SettingsPack.Resolution.Screen_640x480);
        settings.bloom.SetValue(50);

    }
}
