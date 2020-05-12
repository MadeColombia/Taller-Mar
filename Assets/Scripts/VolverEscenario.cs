using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverEscenario : MonoBehaviour
{
    public void volverEscena()
    {
        SceneManager.LoadScene("Playa");
    }
}
