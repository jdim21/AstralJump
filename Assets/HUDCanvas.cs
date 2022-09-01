using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDCanvas : MonoBehaviour
{
    public void FoundMoon()
    {
        Debug.Log("Calling FoundMoon()...");
        GameObject notFoundMoonGameObject = GameObject.Find("NotFoundMoon");
        if (notFoundMoonGameObject != null)
        {
            Debug.Log("Found NotFoundMoon");
        }
        GameObject foundMoonGameObject = GameObject.Find("FoundMoon");
        if (foundMoonGameObject != null)
        {
            Debug.Log("Found FoundMoon");
        }

    }
}
