using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterGameSelection : MonoBehaviour
{
    [SerializeField]
    [Range (1, 4)]
    private int characterIndex;

    private void SelectStage()
    {
        SceneManager.LoadScene(characterIndex);
    }

    private void OnMouseDown()
    {
        SelectStage();
    }
}
