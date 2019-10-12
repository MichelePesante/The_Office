using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeCircleManager : MonoBehaviour
{
    public List<MikeCircleController> mikeCircles;
    private MikeCircleController lastCircle;
    private float timer;

    private void Start()
    {
        foreach (MikeCircleController circle in mikeCircles)
        {
            circle.Setup();
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            if (lastCircle != null && lastCircle.isHighlighted)
            {
                lastCircle.Lowlight();
                LoseLife();
            }
            HighlightRandomCircle();
            timer = 0f;
        }
    }

    private void HighlightRandomCircle()
    {
        int rng = Random.Range(0, 8);

        if (mikeCircles[rng].isHighlighted)
        {
            HighlightRandomCircle();
        }
        else
        {
            mikeCircles[rng].Highlight();
        }

        lastCircle = mikeCircles[rng];
    }

    private void LoseLife()
    {
        UIManager.Instance.RemoveHeart();
    }
}
