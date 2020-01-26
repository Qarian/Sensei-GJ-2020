using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class SettingsUnlockChecker : MonoBehaviour
{
    Settings settings;

    [SerializeField] List<GameObject> extraSettings1;

    private void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;

        bool condition1 = settings.resolution.GetValue() > SenseiGameJam.SettingsPack.Resolution.Screen_960x720 &&
            settings.bloom.GetValue() == 0 &&
            settings.autoSettings.GetValue() == false;

        foreach (GameObject item in extraSettings1)
        {
            item.SetActive(condition1);
        }
    }
}
