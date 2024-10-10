using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPartManager : MonoBehaviour
{
    public GameObject eyePrefab; 
    public Transform eyePoint;
    public GameObject antenniPrefab;
    public Transform antenniPoint;

    private GameObject currentEyes;
    private GameObject currentAntenni;

    
    public void AttachEyes()
    {
        if (currentEyes == null) 
        {
            
            currentEyes = Instantiate(eyePrefab, eyePoint.position, eyePoint.rotation, eyePoint);
        }
    }

    public void AttachAntenni()
    {
        if (currentAntenni == null)
        {

            currentAntenni = Instantiate(antenniPrefab, antenniPoint.position, antenniPoint.rotation, antenniPoint);
        }
    }

    
    public void RemoveEyes()
    {
        if (currentEyes != null)
        {
            Destroy(currentEyes); 
            currentEyes = null; 
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
