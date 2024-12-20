using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollecttables : MonoBehaviour
{
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        DuckoController controller = other.GetComponent<DuckoController>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
            
        }
        
    }
}
