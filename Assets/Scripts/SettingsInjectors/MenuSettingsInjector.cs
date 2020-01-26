using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class MenuSettingsInjector : MonoBehaviour
{
    Settings settings = null;
    public TextMeshProUGUI jumpButton;
    public Slider bloomSlider;
    public TMP_Dropdown resolutionDropdown;
    public Toggle autoSettings;
    public Slider kittensSlider;
    public bool gravitySlider;

    private void Start()
    {
        IDependency dep;
        DI.GetSingleton(typeof(Settings), out dep);
        settings = (Settings)dep;

        autoSettings.isOn = false; settings.autoSettings.GetValue();
        jumpButton.text = settings.input.jump.GetValue().ToString();
        bloomSlider.value = settings.bloom.GetValue();
        resolutionDropdown.itemText.text = settings.resolution.GetValue().ToString();
        kittensSlider.value = settings.cats.GetValue();
        //gravitySlider.value = settings.
    }
}
