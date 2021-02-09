using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScoresandLevel1 : MonoBehaviour
{
  /*  public Text playerDisplay;
    public Text scoreDisplay;*/

    public void Awake()
    {
        if (DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);

        }
        /*playerDisplay.text = "Player: " + DBManager.username;
        scoreDisplay.text = "Score: " + DBManager.score;*/
    }

    public void CallSaveDataLevel()
    {
        StartCoroutine(SavePlayerDataLevel());
    }

    IEnumerator SavePlayerDataLevel()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("score", DBManager.score);
        form.AddField("level", DBManager.level);

        WWW www = new WWW("http://192.168.1.198/sqlconnect/savedatis.php", form);
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("Game saved");
        }
        else
        {
            Debug.Log("Save failed Error#" + www.text);
        }
        DBManager.LogOut();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void IncreaseValuesScore()
    {
        DBManager.score += PointsControllerActivator.points;
        DBManager.level++;
       // scoreDisplay.text = "Score=" + DBManager.score;
    }
}
