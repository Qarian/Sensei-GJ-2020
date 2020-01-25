using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class Jump : MonoBehaviour
{
    KeyCode code = KeyCode.None;
    Settings settings = null;
    [SerializeField]
    private float jumpHeight = 10.0f;

    private Vector2 jumpDir= new Vector2(0,1);

    private Rigidbody2D rb;

    public KeyCode jumpKey;

    private void Start()
    {
        IDependency dep;
        DI.GetSingleton(typeof(Settings), out dep);
        settings = (Settings)dep;
        if(settings != null)
        {
            code = settings.input.jump.GetValue();
        }
        else
        {
            code = KeyCode.None;
        }
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(code))
        {
            rb.velocity = jumpHeight * jumpDir;
        }
    }
}
