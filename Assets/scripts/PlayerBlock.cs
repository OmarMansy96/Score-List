using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBlock : MonoBehaviour
{
    private int phasenumber,points;
    //private TMP_InputField phaseInput;

    void Start()
    {
        //phaseInput =transform.Find("index").GetComponentInChildren<TMP_InputField>();
    }

    void Update()
    {

    }


    public void SetPhases(string phaseNumber)
    {
        phasenumber = int.Parse(phaseNumber);
        Debug.Log(phaseNumber);
    }

    public void SetPoints(string point)
    {
        points = int.Parse(point);
        Debug.Log(point);

    }








}
