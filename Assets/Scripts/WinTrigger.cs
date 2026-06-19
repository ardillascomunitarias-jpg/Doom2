using UnityEngine;
using UnityEngine.UI;
public class WinTrigger : MonoBehaviour
{
    public GameObject winText;
    public AudioSource winSound;
    
 
    private bool hasTriggered = false;
 
    void OnTriggerEnter(Collider other)
    {
        if (hasTriggered) return;
        
        if (other.CompareTag("Player"))
        {
            hasTriggered = true;
            
            winText.SetActive(true);
            
            SoundManager.instance.Play("WinnerSonido");
            
            
        }
    }
}