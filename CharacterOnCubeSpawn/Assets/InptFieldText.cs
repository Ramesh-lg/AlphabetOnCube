using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InptFieldText : MonoBehaviour
{
    public InputField mainInputField;
    string input;
    string s;
    CubeSpawner cubeSpawner;


    /* public void ReadStringInput(string s)
     {
         input = s;
         Debug.Log(s);
     }
 */

    public void Start()
    {
        mainInputField.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck()
    {
        input = mainInputField.text;

        //cubeSpawner.CubeSpawn(input);

        Debug.Log("Value Changed " + input);
    }
}
