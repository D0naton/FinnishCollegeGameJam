using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPartManager : MonoBehaviour
{
    public GameObject armPrefab; 
    public Transform armPoint;
    public GameObject antenniPrefab;
    public Transform antenniPoint;

    private GameObject currentArm;
    private GameObject currentAntenni;

    
    public void AttachArm()
    {
        if (currentArm == null) 
        { 
            currentArm = Instantiate(armPrefab, armPoint.position, armPoint.rotation, armPoint);
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
        if (currentArm != null)
        {
            Destroy(currentArm); 
            currentArm = null; 
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
