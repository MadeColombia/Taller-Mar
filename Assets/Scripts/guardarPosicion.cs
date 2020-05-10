using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardarPosicion : MonoBehaviour
{
    public float Posx, Posy, Posz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GuardarDatosPos() 
    {
        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        PlayerPrefs.SetFloat("PosicionZ", transform.position.z);
        Debug.Log("Datos Guardados Correctamente");
    }
}
