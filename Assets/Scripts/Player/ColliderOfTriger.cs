using UnityEngine;

public class ColliderOfTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Есть хуй");
    }
}
