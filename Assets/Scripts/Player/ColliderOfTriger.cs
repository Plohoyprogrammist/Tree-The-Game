using UnityEngine;

public class ColliderOfTriger : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, transform.rotation.y, 0f);
    }
}
