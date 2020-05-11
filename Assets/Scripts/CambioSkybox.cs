using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioSkybox : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
    public Toggle noche;
     public Light mylight;

    public void cambioSkyBox()
    {
        if (noche.isOn == true)
        {
            RenderSettings.skybox = skybox2;
            mylight.color = Color.grey;
        }
        else 
        {
            RenderSettings.skybox = skybox1;
            mylight.color = Color.white;
        }
    }
    public void cambioLuz()
    {
        if (noche.isOn == true)
        {
            mylight.color = Color.grey;
        }
        else
        {        
            mylight.color = Color.white;
        }
    }
}
