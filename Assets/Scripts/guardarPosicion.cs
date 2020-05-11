using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class guardarPosicion : MonoBehaviour
{
    public float Posx, Posy, Posz;
    public Text tx;
    public List<Vector3> listaPos;
    
    void Start()
    {
        listaPos = new List<Vector3>();
        
       
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
        tx.text = "(X: "+PlayerPrefs.GetFloat("PosicionX").ToString() + ", Y: " + PlayerPrefs.GetFloat("PosicionY").ToString() + ", Z: " + PlayerPrefs.GetFloat("PosicionZ").ToString()+")";
        
        Debug.Log("Datos Guardados Correctamente");
    }

    public void CargarDatos()
    {
        PlayerPrefs.GetFloat("PosicionX");
        PlayerPrefs.GetFloat("PosicionY");
        PlayerPrefs.GetFloat("PosicionZ");
    }
}
