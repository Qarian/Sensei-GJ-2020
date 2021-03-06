﻿using System;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;
using TMPro;
using UnityEditor;
using UnityEngine;


    public class DropDownSettings : MonoBehaviour
    {
        private Settings settings;
        private TMP_Dropdown tmpDropdown;

        private void Start()
        {
            
            IDependency dependency;
            DI.GetSingleton(typeof(Settings), out dependency);
            settings = dependency as Settings;
        
            
            tmpDropdown = GetComponent<TMP_Dropdown>();
            tmpDropdown.onValueChanged.AddListener(OnValueChanged);
            tmpDropdown.SetValueWithoutNotify(settings.intputRes);
        }
        
        public void OnValueChanged(int newValue)
        {
            SenseiGameJam.SettingsPack.Resolution resolution;
            Enum.TryParse("Screen_" + tmpDropdown.options[newValue].text, out resolution);
            settings.resolution.SetValue(resolution);
            settings.intputRes = newValue;
        }
    }