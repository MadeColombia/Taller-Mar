using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{

    string[] palmsArray;

    string myFilePath, fileName;

    void Start()
    {
        fileName = "Palms.txt";
        myFilePath = Application.dataPath + "/" + fileName;
        ReadFromTheLine();
     
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
