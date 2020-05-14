using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class guardarPosicion : MonoBehaviour
{
    public float Posx, Posy, Posz;
    public Text tx,tx2,tx3;
    public GameObject panel;
    public List<Vector3> listaPos;
    Vector3 posPlayer;
    
    void Start()
    {
        listaPos = new List<Vector3>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;


        GuardarDatosPos(posPlayer);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform != null)
                {
                    tx.text = hit.transform.gameObject.name;
                    tx2.text = "(X: " + PlayerPrefs.GetFloat("PosicionX").ToString() + ", Y: " + PlayerPrefs.GetFloat("PosicionY").ToString() + ", Z: " + PlayerPrefs.GetFloat("PosicionZ").ToString() + ")";
                    tx.transform.gameObject.SetActive(true);
                    tx2.transform.gameObject.SetActive(true);
                    tx3.transform.gameObject.SetActive(true);
                    panel.SetActive(true);
                    


                }
            }

        } else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform != null)
                {
                     
                    tx.transform.gameObject.SetActive(false);
                    tx2.transform.gameObject.SetActive(false);
                    tx3.transform.gameObject.SetActive(false);
                    panel.SetActive(false);



                }
            }
        }
    }

    
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tx.transform.gameObject.SetActive(false);
            tx2.transform.gameObject.SetActive(false);
            panel.SetActive(false);
            tx3.transform.gameObject.SetActive(false);
        }
    }

    public void GuardarDatosPos(Vector3 posicion) 

    {
        
        PlayerPrefs.SetFloat("PosicionX",posicion.x);
        PlayerPrefs.SetFloat("PosicionY", posicion.y);
        PlayerPrefs.SetFloat("PosicionZ", posicion.z);
        
        Debug.Log("Datos Guardados Correctamente");
       


    }

    public Vector3 CargarDatos()
    {
        Vector3 posicion;
        posicion.x=PlayerPrefs.GetFloat("PosicionX");
        posicion.y = PlayerPrefs.GetFloat("PosicionY");
        posicion.z = PlayerPrefs.GetFloat("PosicionZ");
        return posicion;
    }
}
