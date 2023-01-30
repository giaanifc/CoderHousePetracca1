using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var p_portal = GetComponent<HarryController>();
        if (p_portal != null)
        {
            p_portal.MakeLittle();
        }
    }
}
