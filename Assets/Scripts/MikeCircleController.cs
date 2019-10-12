using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeCircleController : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite lowlightImage;
    public Sprite highlightImage;
    public bool isHighlighted;

    public void Setup()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Highlight()
    {
        sr.sprite = highlightImage;
        isHighlighted = true;
    }

    public void Lowlight()
    {
        sr.sprite = lowlightImage;
        isHighlighted = false;
    }

    private void OnMouseDown()
    {
        if (isHighlighted)
        {
            UIManager.Instance.UpdatePoints();
            Lowlight();
        }
    }
}
