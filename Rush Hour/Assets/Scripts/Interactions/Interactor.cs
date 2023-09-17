using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 1f;
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private InteractionText _interactionPromptUI;
    // private I_interactable interactable = null;


    private readonly Collider [] _collider = new Collider[3];
    [SerializeField] private int _numFound;

    private I_interactable _interactable;

    void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _collider, _interactableMask); 
        // I_interactable interactable = null;

        if (_numFound > 0)
        {
            _interactable = _collider[0].GetComponent < I_interactable > ();
            if (_interactable != null)
            {
                if (!_interactionPromptUI.isDisplayed)
                    _interactionPromptUI.SetUp(_interactable.InteractionPrompt);

                

                // _interactable.Interact(this);
                if (Keyboard.current.eKey.wasPressedThisFrame)
                {
                    _interactable.Interact(this);
                }
            }
        }
        else
        {
            if (_interactable != null) _interactable = null;
            if (_interactionPromptUI.isDisplayed) _interactionPromptUI.Close();
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
