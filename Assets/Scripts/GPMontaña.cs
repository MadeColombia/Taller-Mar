using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

//using System.Runtime.Remoting.Messaging;

public class GPMontaña : MonoBehaviour
{
    private float Posx, Posy, Posz;
    private string tx;
    public float Velocidad;
    private int i = 1;
    //public List<Vector3> listaPos;


    void Start()
    {

        StartCoroutine(Empezar());
    }

    public IEnumerator Empezar()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(Velocidad);
            GuardarDP();
            

        }
        
    }

   

    public void GuardarDP()

    {

        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        PlayerPrefs.SetFloat("PosicionZ", transform.position.z);

        tx = "(X: " + PlayerPrefs.GetFloat("PosicionX").ToString() + ", Y: " + PlayerPrefs.GetFloat("PosicionY").ToString() + ", Z: " + PlayerPrefs.GetFloat("PosicionZ").ToString() + ")";
        Creartxt();
        Debug.Log("Datos Guardados Correctamente");
        
    }

    public void CargarD()
    {
        PlayerPrefs.GetFloat("PosicionX");
        PlayerPrefs.GetFloat("PosicionY");
        PlayerPrefs.GetFloat("PosicionZ");
    }

    void Creartxt()
    {
        //Path del texto
        string path = Application.dataPath + "/Pos.txt";

        //Crear file si no existe
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Posiciones de Personaje \n\n");
        }

        //Contenido del file 
        string contenido = "posicion"+""+i+":" + "" + tx + "\n";
        i++;
        //Poner el texto 
        File.AppendAllText(path, contenido);
    }
}