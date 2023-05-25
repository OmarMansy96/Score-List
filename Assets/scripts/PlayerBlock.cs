using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBlock : MonoBehaviour
{
    public string phasenumber,points;

   

    void Start()
    {
        

    }

    void Update()
    {

    }
    public void SetPhases(string phase)
    {
        phasenumber = phase;
        Debug.Log(phasenumber);
    }

    public void SetPoints(string point)
    {
        points = point;
    }






    private void Start2()
    {
        GameObject parentObject = GameObject.Find(" Object ");

        if (parentObject != null)
        {
            InputField[] inputFields = parentObject.GetComponentsInChildren<InputField>();
            
            int maxNumber = int.MinValue; 

            InputField largestInputField = null; 

            if (inputFields.Length > 0)
            {
                foreach (InputField inputField in inputFields)
                {
                    int currentNumber;
                    if (int.TryParse(inputField.text, out currentNumber) && currentNumber > maxNumber)
                    {
                        maxNumber = currentNumber;
                        largestInputField = inputField;
                    }
                }
            }

            if (largestInputField != null)
            {
                largestInputField.transform.SetAsFirstSibling();
            }
        }
    }


}
