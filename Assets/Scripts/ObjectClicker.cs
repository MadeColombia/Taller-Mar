﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            { 
                if(hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
    }

    public void PrintName(GameObject go)
    {
        print(go.name);
    }
}
