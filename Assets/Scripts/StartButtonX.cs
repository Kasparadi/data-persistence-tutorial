using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StartButtonX : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInputField;

    private void Start()
    {

        playerNameInputField = GameObject.FindGameObjectWithTag("Input").GetComponent<TMP_InputField>();
    }

    public void StartGame()
    {
        MenuManagerX.LoadScoreFromJson();

        if (playerNameInputField.text == "")
        {
            MenuManagerX.playerName = "Player";
        }
        else
        {
            MenuManagerX.playerName = playerNameInputField.text;
        }
        
        SceneManager.LoadScene("main");
    }
}
