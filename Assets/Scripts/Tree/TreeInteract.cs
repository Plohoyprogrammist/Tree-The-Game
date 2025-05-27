using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class TreeInteract : MonoBehaviour, IInteractable
{
    public string nameObject;
    public int[] dialogIndex;

    public ManagerText managerText;

    private void Start()
    {
        managerText = GetComponent<ManagerText>();
    }

    public void Interact()
    {
        Debug.Log("ZalupaVerbluda");
        managerText.Dialoge(dialogIndex);
    }

    public string GetName()
    {
        return nameObject;
    }
}
