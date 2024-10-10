using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider energySlider;  
    public float maxEnergy = 100f; 
    public float drainRate = 5f;  

    private float currentEnergy;

    void Start()
    {
        currentEnergy = maxEnergy;
        energySlider.maxValue = maxEnergy;
        energySlider.value = currentEnergy;
    }

    void Update()
    {
       
        currentEnergy -= drainRate * Time.deltaTime;

        
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);

        
        energySlider.value = currentEnergy;

        
        if (currentEnergy <= 0)
        {
            Debug.Log("Energy drained!");
        }
    }

    public void AddEnergy(float amount)
    {
        currentEnergy += amount;
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);
        energySlider.value = currentEnergy;
    }
}
