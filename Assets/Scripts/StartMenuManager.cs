using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TMP_InputField playerName;
    public GameObject errorMsg;
    public void StartGame()
    {
        if (string.IsNullOrEmpty(playerName.text))
        {
            errorMsg.SetActive(true);
        }
        else
        {
            Playerinfo.Instance.playerName = playerName.text;
            SceneManager.LoadScene(1);
        }
    }
}
