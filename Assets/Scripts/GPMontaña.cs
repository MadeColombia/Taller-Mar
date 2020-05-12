using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.UIElements;

//using System.Runtime.Remoting.Messaging;

public class GPMontaña : MonoBehaviour
{
    private float Posx, Posy, Posz;
    private string tx;
    public float Velocidad;
    private int i = 1;
    private List<Vector3> Punto;
    private GameObject sphere;
    private GameObject sphera;
    public UnityEngine.UI.Button Guardar;
    public Material mat;
    public Material mat2;




    public void Start()
    {
        StartCoroutine(Empezara());
        StartCoroutine(Empezar());
        StartCoroutine(EmpezarC());
    }

    public IEnumerator Empezara()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(0.2f);
            GuardarDP();
            

        }
        
    }

    public IEnumerator Empezar()
    {
        while (true)
        {

            yield return new WaitForSeconds(Velocidad);
            CargarD();


        }

    }

    public IEnumerator EmpezarC()
    {
        while (true)
        {

            yield return new WaitForSeconds(0.4f);
            camino();


        }

    }



    public void GuardarDP()

    {

        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        PlayerPrefs.SetFloat("PosicionZ", transform.position.z);

        
        //CargarD();
        Debug.Log("Datos Guardados Correctamente");
        
    }

    void camino()
    {
        PlayerPrefs.GetFloat("PosicionX");
        PlayerPrefs.GetFloat("PosicionY");
        PlayerPrefs.GetFloat("PosicionZ");
        sphera = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sphera.transform.position = new Vector3(PlayerPrefs.GetFloat("PosicionX"), PlayerPrefs.GetFloat("PosicionY")+100, PlayerPrefs.GetFloat("PosicionZ"));
        sphera.transform.localScale = new Vector3(3f, 3f, 3f);
        sphera.GetComponent<MeshRenderer>().material = mat2;
        
        sphera.SetActive(true);
    }

    public void CargarD()
    {

        PlayerPrefs.GetFloat("PosicionX");
        PlayerPrefs.GetFloat("PosicionY");
        PlayerPrefs.GetFloat("PosicionZ");
        Vector3 L = new Vector3(PlayerPrefs.GetFloat("PosicionX"), PlayerPrefs.GetFloat("PosicionY"), PlayerPrefs.GetFloat("PosicionZ"));
        tx = "(X: " + PlayerPrefs.GetFloat("PosicionX").ToString() + ", Y: " + PlayerPrefs.GetFloat("PosicionY").ToString() + ", Z: " + PlayerPrefs.GetFloat("PosicionZ").ToString() + ")";
        Creartxt();

        // se crea esfera
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sphere.transform.position = new Vector3(PlayerPrefs.GetFloat("PosicionX"), PlayerPrefs.GetFloat("PosicionY")+100, PlayerPrefs.GetFloat("PosicionZ"));
        sphere.transform.localScale = new Vector3(10f, 10f, 10f);
        sphere.GetComponent<MeshRenderer>().material = mat;


        sphere.SetActive(true);
        //sphere.transform.localScale(5, 5, 5);
        Debug.Log("Esfera ha sido creada en:");

        
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

    public void toQuit()
    {
        Application.Quit();
        Debug.Log("Juego finalizado");
    }
}