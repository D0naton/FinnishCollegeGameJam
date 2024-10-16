using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectControl : MonoBehaviour
{
    public ParticleSystem dirtParticle;
    public bool effectOnAndOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            effectOnAndOff = true;

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            effectOnAndOff = false;
        }
       
        if (Input.GetKeyDown(KeyCode.D))
        {
            effectOnAndOff = true;

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            effectOnAndOff = false;
        }



        if (effectOnAndOff == true)
        {
            dirtParticle.Play();
        }
        if (effectOnAndOff == false)
        {
            dirtParticle.Stop();
        }
        
        

    }

}
