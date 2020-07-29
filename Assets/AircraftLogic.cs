using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftLogic : MonoBehaviour
{

    public float speedVal = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speedVal;
    }
}
