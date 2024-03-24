using System;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Renderer _renderer;
    private BoxCollider2D _boxCollider2D;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
        _renderer.enabled = false;
        _boxCollider2D.enabled = false;
    }
}