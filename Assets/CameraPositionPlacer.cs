using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionPlacer : MonoBehaviour
{

    public GameObject cameraSetup;
    // Start is called before the first frame update
    void Start()
    {
        cameraSetup.transform.position = transform.position;
           
    }

    // Update is called once per frame
    void Update()
    {
        cameraSetup.transform.position = transform.position;
        
    }
}
