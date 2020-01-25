using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SenseiGameJam.SettingsPack;

namespace SenseiGameJam.SettingsInjectorsPack
{
    public class SettingsInjector : MonoBehaviour
    {
        public Settings settings;

        // Start is called before the first frame update
        void Start()
        {
            FindOrCreateSettings();
            CreateSettings();
            StartSettings();
        }

        void FindOrCreateSettings()
        {
            settings = GameObject.FindObjectOfType<Settings>();
            if(settings == null)
            {
                GameObject settingsObject = new GameObject("Settings", components: typeof(Settings));
                settings = settingsObject.GetComponent<Settings>();
            }
        }

        void CreateSettings()
        {
            settings.bloom = gameObject.AddComponent<BloomSetting>() as BloomSetting;
            settings.resolution = gameObject.AddComponent<ResolutionSetting>() as ResolutionSetting;
            settings.cats = gameObject.AddComponent<CatsSetting>() as CatsSetting;
            settings.specialSettings = gameObject.AddComponent<SpecialSettingsSetting>() as SpecialSettingsSetting;
            CreateInput();
        }

        void CreateInput()
        {
            settings.input = gameObject.AddComponent<InputSettings>();
            settings.input.jump = gameObject.AddComponent<JumpSetting>() as JumpSetting;
        }

        void StartSettings()
        {
            settings.bloom.StartSetting();
            settings.resolution.StartSetting();
            settings.cats.StartSetting();
            settings.specialSettings.StartSetting();
            StartInput();
        }

        void StartInput()
        {
            settings.input.jump.StartSetting();
        }
    }
}