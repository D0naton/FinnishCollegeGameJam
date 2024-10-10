using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public RobotPartManager robotPartManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Lens"))
            {
                robotPartManager.AttachEyes();
                Destroy(gameObject);
            }

            if (gameObject.CompareTag("Antenna"))
            {
                robotPartManager.AttachAntenni();
                Destroy(gameObject);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
