using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactive : MonoBehaviour
{
    public Camera m_cameraToActivate;

    // Start is called before the first frame update
    void Start()
    {
        m_cameraToActivate.gameObject.SetActive(true);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
