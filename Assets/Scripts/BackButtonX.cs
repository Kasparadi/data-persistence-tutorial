using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonX : MonoBehaviour
{

    public void ClickBack()
    {
        SceneManager.LoadScene("menu");
    }
}
