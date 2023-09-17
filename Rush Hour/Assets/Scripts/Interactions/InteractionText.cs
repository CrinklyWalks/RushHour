using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class InteractionText : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private TextMeshProUGUI _promptText;

    private void Start()
    {
        _panel.SetActive(false);
    }

    public bool isDisplayed = false;

    public void SetUp(string promptText)
    {
        _promptText.text = promptText;
        _panel.SetActive(true);
        isDisplayed = true;
    }

    public void Close()
    {
        _panel.SetActive(false);
        isDisplayed = false;
    }
}
