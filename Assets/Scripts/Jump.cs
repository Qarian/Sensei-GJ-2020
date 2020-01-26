using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using SenseiGameJam.DependencyInjection;
using SenseiGameJam.SettingsPack;

public class Jump : MonoBehaviour
{
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
            jumpKey = settings.input.jump.GetValue();
        }
        else
        {
            jumpKey = KeyCode.None;
        }
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (!settings.gravity)
            rb.gravityScale = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown(jumpKey))
        {
            rb.velocity = jumpHeight * jumpDir;
        }
    }
}
