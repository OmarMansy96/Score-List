using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class gameManager : MonoBehaviour
{
    public Transform listPos;
    public GameObject playerBlock;
    public GameObject exitPanel;
    //List<int> phases;
    void Start()
    {
        exitPanel.SetActive(false);
    }

    void Update()
    {
        //foreach (var obj in listPos)
        //{
        //    phases.Add(int.Parse(GetComponentInChildren<TMP_InputField>().text));

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            exitPanel.SetActive(true);

        }

    }

    public void CreateNewPlayer()
    {
        var newPlayer = Instantiate(playerBlock, listPos.transform);
        //newPlayer.GetComponent<PlayerBlock>().phasenumber;
       
    }

    public void ResetGame()
    {
        foreach(Transform obj in listPos)
        {
            Destroy(obj.gameObject);
        }
        

    }
    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("Exit...");
    }

    void showExitMessage(bool panelstatus)
    {
        exitPanel.SetActive(panelstatus);

    }
}
