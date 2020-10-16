using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private bool m_IsQuitting = true;
    private bool m_IsLaunched = false;

    private void OnEnable()
    {
        EventBus.StartListening("Launch", Launch);
    }

    private void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    private void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Launch", Launch);
        }
    }

    void Launch()
    {
        if (!m_IsLaunched)
        {
            m_IsLaunched = true;
            Debug.Log("Launch Event");
        }
    }
}
