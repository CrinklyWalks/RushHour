using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leave : MonoBehaviour, I_interactable
{
    public string whatScene;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        SceneManager.LoadScene(whatScene);
        return true;
    }
}
