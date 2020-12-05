using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RetryMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void ReturnMainMenuGame()
    {
        SceneManager.LoadScene(0);
    }
}
