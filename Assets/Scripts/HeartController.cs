using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite brokenImage;
    public Sprite fullImage;
    public bool isBroken;

    public void Setup()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Highlight()
    {
        sr.sprite = fullImage;
        isBroken = false;
    }

    public void Lowlight()
    {
        sr.sprite = brokenImage;
        isBroken = true;
    }
}
