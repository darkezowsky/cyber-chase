using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
    // Use this for initialization
    void Awake()
    {
        // Zmiana FindObjectOfType na FindFirstObjectByType
        if (!FindFirstObjectByType<EventSystem>())
        {
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>(); // Removed forceModuleActive
        }
    }
}
