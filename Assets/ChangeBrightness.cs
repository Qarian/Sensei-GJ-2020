using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBrightness : MonoBehaviour
{
    private Image _spriteRenderer;
    private Color _color;

    public float alpha;

    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<Image>();
        _color = _spriteRenderer.color;
        alpha = _color.a;
    }

    private void Update()
    {
        ChangeAlpha();
    }

    void ChangeAlpha()
    {
        _color.a = alpha;
    }
}
