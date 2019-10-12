using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private int currentScore;
    public TextMeshProUGUI Score;
    public List<HeartController> Hearts;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        foreach (HeartController heart in Hearts)
        {
            heart.Setup();
        }
    }

    public void UpdatePoints()
    {
        currentScore++;
        Score.text = "Score: " + currentScore;
    }

    public void AddHeart()
    {
        for (int i = 0; i < Hearts.Count; i++)
        {
            if (Hearts[i].isBroken)
            {
                Hearts[i].Highlight();
                return;
            }
        }
    }

    public void RemoveHeart()
    {
        for (int i = 2; i >= 0; i--)
        {
            if (!Hearts[i].isBroken)
            {
                Hearts[i].Lowlight();

                if (i <= 0)
                {
                    SceneManager.LoadScene(0);
                }
                return;
            }
        }
    }
}
