using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    public Transform listPos;
    public GameObject playerBlock;
    int phaseLevel;
    string x;
    void Start()
    {
         //x = GameObject.Find("playerBlock/index");
        
    }

    void Update()
    {
        foreach (GameObject obj in listPos)
        {
            Destroy(obj);
        }
    }

    public void CreateNewPlayer()
    {
        var newPlayer = Instantiate(playerBlock, listPos);
        phaseLevel =int.Parse( newPlayer.GetComponent<PlayerBlock>().phasenumber);
       
    }

    public void ResetGame()
    {

    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
