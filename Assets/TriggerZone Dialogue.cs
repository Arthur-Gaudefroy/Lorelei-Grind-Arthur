using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;

public class Triggerdialogue : MonoBehaviour
{
    public AudioSource m_audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // Perform an action when the trigger is entered
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        m_audioSource.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
