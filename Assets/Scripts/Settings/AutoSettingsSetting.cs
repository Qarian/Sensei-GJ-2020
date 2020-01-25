using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SenseiGameJam.SettingsPack
{
    public class AutoSettingsSetting : MonoBehaviour, ISetting<bool>
    {
        [SerializeField]
        bool value = true;

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

