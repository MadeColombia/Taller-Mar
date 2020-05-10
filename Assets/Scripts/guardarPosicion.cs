using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class guardarPosicion : MonoBehaviour
{
    public float Posx, Posy, Posz;
    public int tic;
    public Timer timer;
    public 
    void Start()
    {
        tic = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
 
            GuardarDatosPos();
 
    }

    public void GuardarDatosPos() 
    {
        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        PlayerPrefs.SetFloat("PosicionZ", transform.position.z);
        Debug.Log("Datos Guardados Correctamente");
    }

    public void CargarDatos()
    {
        PlayerPrefs.GetFloat("PosicionX");
        PlayerPrefs.GetFloat("PosicionY");
        PlayerPrefs.GetFloat("PosicionZ");
    }
}
