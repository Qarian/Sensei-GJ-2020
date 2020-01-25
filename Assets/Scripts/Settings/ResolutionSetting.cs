using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SenseiGameJam.SettingsPack
{
    public class ResolutionSetting : MonoBehaviour, ISetting<Resolution>
    {
        [SerializeField]
        Resolution value = Resolution.Screen_640x480;

        [SerializeField]
        Material material;

        private void Start()
        {
            material = Resources.Load("Material/Blur", typeof(Material)) as Material;
            Debug.Log(material);
            material.SetFloat("_Size", (float)value);
        }

        public void FixedUpdateSetting()
        {
            throw new System.NotImplementedException();
        }

        public Resolution GetValue()
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

        public void SetValue(Resolution value)
        {
            this.value = value;
            material.SetFloat("Size", (float) value);
        }

        public void SetMaterial(Material material)
        {
            this.material = material;
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