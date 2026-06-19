using UnityEngine;
using UnityEngine.Events;

public class Trigger2 : MonoBehaviour
{
   [SerializeField]
   private UnityEvent onTriggered;

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onTriggered?.Invoke();
            Destroy(gameObject);
        }
    }
}
