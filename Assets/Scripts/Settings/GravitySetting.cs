using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SenseiGameJam.SettingsPack
{
    public class GravitySetting : MonoBehaviour, ISetting<bool>
    {
        bool value;

        public void SetGravity()
        {
            Settings.settings.gravity = transform.GetComponent<Toggle>().isOn;
            value = transform.GetComponent<Toggle>().isOn;
        }

        public void FixedUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public bool GetValue()
        {
            return value;
        }

        public void LateUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public void OnSceneLoad()
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(bool value)
        {
            this.value = value;
        }

        public void StartSetting()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSetting()
        {
            throw new System.NotImplementedException();
        }
    }
}

