using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnPlay : MonoBehaviour
{
    // So that when I hit play the example mesh and plane will dissappear
    void Start()
    {
        gameObject.SetActive(false);
    }
}
