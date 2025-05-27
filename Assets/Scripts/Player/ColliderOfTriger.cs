using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ColliderOfTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Есть хуй");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Хуй");
            IInteractable interac = other.gameObject.GetComponent<IInteractable>();
            Debug.Log("Хуй1");
            interac.Interact();
        }
    }
}
