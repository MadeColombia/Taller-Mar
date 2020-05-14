using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;






public class FileManager : MonoBehaviour
{

    public string[] palmsArray,Names;
    public Vector3[] Locations;



    string myFilePath;
     


    void Start()
    {
        




        
        myFilePath = "./Palms.txt" ;
        


        string[] filelines = File.ReadAllLines(myFilePath);
        Names = new string[filelines.Length];
        Locations = new Vector3[filelines.Length];
        for (int i = 0; i < filelines.Length; i++)
        {
            string[] parts = filelines[i].Split("/"[0]);
            //Names[i] = parts[0];
            string coords = parts[1].Substring(1, parts[1].Length - 3);
            string[] coord = coords.Split(","[0]);
            float coord0 = float.Parse(coord[0]);
            float coord1 = float.Parse(coord[1]);
            float coord2 = float.Parse(coord[2]);
            Locations[i] = new Vector3(coord0, coord1, coord2);
            Debug.Log(Names[i] + " : " + Locations[i].ToString());
        }

    }
   



    public void ReadFromTheLine()
    {
        palmsArray = File.ReadAllLines(myFilePath);
        /*
            foreach (string line in palmsArray) 
            {
                print(line); 
            }
        */
        int randomNumber = Random.Range(0, palmsArray.Length);
        print(palmsArray[randomNumber]);
    }
}
