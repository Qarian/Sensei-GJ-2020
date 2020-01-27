using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class AutoSettingsPanel : MonoBehaviour
{
    [SerializeField]
    Canvas canvas = default;
    Settings settings;

    void Start()
    {
        IDependency dependency;
        DI.GetSingleton(typeof(Settings), out dependency);
        settings = dependency as Settings;


        if (settings.autoSettings.GetValue() == false)
        {
            gameObject.SetActive(false);
            canvas.sortingOrder = -1;
        }
            
        else
        {
            canvas.sortingOrder = 1;
            settings.input.jump.SetValue(KeyCode.None);
        }
    }


    public void ClosePanel()
    {
        if(settings.autoSettings.GetValue())
        {
            settings.resolution.SetValue(SenseiGameJam.SettingsPack.Resolution.Screen_640x480);
            settings.intputRes = 0;
            settings.bloom.SetValue(50);
            gameObject.SetActive(false);
            canvas.sortingOrder = -1;
        }
    }
}
