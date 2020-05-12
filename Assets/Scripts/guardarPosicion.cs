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
    public Text tx,tx2;
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


                    
                }
            }

        }
    }

    public void GuardarDatosPos(Vector3 posicion) 

    {
        
        PlayerPrefs.SetFloat("PosicionX",posicion.x);
        PlayerPrefs.SetFloat("PosicionY", posicion.y);
        PlayerPrefs.SetFloat("PosicionZ", posicion.z);
        
        Debug.Log("Datos Guardados Correctamente");
        //for (float f = 1f; f >= 0; f -= 0.1f)
        //{
        //    Color c = tx2.color;
        //    Color c1 = tx.color;
        //    c.a = f;
        //    c1.a = f;
        //    tx2.color = c;
        //    tx.color = c;
        //    yield return new WaitForSeconds(.1f);





        //    // PrintName(hit.transform.gameObject);

        //}


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
