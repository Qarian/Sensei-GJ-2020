﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SenseiGameJam.SettingsPack;
using UnityEngine.Rendering.PostProcessing;

namespace SenseiGameJam.SettingsInjectorsPack
{
    public class SettingsInjector : MonoBehaviour
    {
        public Settings settings;
        public InputSettings input;

        // Start is called before the first frame update
        void Start()
        {
            FindOrCreateSettings();
        }

        void FindOrCreateSettings()
        {
            settings = GameObject.FindObjectOfType<Settings>();
            if(settings == null)
            {
                Debug.Log("Create new settings");
                GameObject settingsObject = new GameObject("Settings", components: typeof(Settings));
                settings = settingsObject.GetComponent<Settings>();
                CreateSettings();
                StartSettings();
            }
        }

        void CreateSettings()
        {
            settings.bloom = settings.gameObject.AddComponent<BloomSetting>() as BloomSetting;
            settings.resolution = settings.gameObject.AddComponent<ResolutionSetting>() as ResolutionSetting;
            settings.cats = settings.gameObject.AddComponent<CatsSetting>() as CatsSetting;
            settings.specialSettings = settings.gameObject.AddComponent<SpecialSettingsSetting>() as SpecialSettingsSetting;
            settings.autoSettings = settings.gameObject.AddComponent<AutoSettingsSetting>() as AutoSettingsSetting;
            CreateInput();
        }

        void CreateInput()
        {
            input = settings.input = settings.gameObject.AddComponent<InputSettings>();
            input.jump = input.gameObject.AddComponent<JumpSetting>() as JumpSetting;
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