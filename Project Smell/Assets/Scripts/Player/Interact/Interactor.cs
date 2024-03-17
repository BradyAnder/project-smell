using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform interactorSource;
    public float interactRange;
    public Image highlighterImage;

    private void Awake()
    {
        interactorSource = Camera.main.transform;

        GameObject highlightObj = GameObject.Find("Highlighter");
        highlighterImage = highlightObj.GetComponent<Image>();
    }

    public void Start()
    {
        highlighterImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(interactorSource.position, interactorSource.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, interactRange))
        {
            if (hit.collider.gameObject.TryGetComponent(out IInteractable interactOdj))
            {
                highlighterImage.enabled = true;
            }
        }
        else
        {
            highlighterImage.enabled = false;
        }

            if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactOdj))
                {
                    interactOdj.Interact();
                }
            }
        }
    }
}
