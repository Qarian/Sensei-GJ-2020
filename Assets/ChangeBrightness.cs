using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBrightness : MonoBehaviour
{
    private Image _image;
    private Color _color;

    [Range(0,1)]
    public float alpha;

    private void Start()
    {
        _image = gameObject.GetComponent<Image>();
        _color = _image.color;
        alpha = _color.a;
    }

    private void Update()
    {
        ChangeAlpha();
    }

    void ChangeAlpha()
    {
        _color.a = alpha;
        _image.color = _color;
    }
}
