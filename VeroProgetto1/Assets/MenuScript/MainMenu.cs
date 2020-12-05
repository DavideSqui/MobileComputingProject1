using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NextGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //BEGINNIN FROM START
    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
    //RETURN TO MENU 
    public void ReturnMenuGame()
    {
        SceneManager.LoadScene(0);
    }
    //SUBMITTING NAME
    public void SubmitNameProfileMenuGame()
    {
        SceneManager.LoadScene(4);
    }
    //EXIT GAME
    public void QuitGame() {
        Debug.Log("QUITTED!");
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {   
    }
}
