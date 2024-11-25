using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDetection: MonoBehaviour
{
    public int m_totalThune = 0;

    private void OnTriggerEnter(Collider other)
    {
        TestPickup pickup = other.GetComponentInParent<TestPickup>();
        if (pickup)
        {
            m_totalThune += pickup.m_value;
            Destroy(pickup.gameObject);
        }
    }
}
