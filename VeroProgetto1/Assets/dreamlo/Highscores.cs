using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscores : MonoBehaviour
{
    const string privateCode = "QBzKpqQdJE-YeeeZyeHmmQNKysDPxsGEu2y4DlKQDqAg";
    const string publicCode = "5fbba560eb36fd2714e1b4e6";
    const string webURL = "http://dreamlo.com/lb/";
    public Highscore[] highscoresList;
    static Highscores instance;

    public DisplayHighscores highscoresDisplay;
     void Awake()
    {
        instance = this;
        highscoresDisplay.GetComponent<DisplayHighscores>();
    }
    public static void AddNewHighscore(string username, int score)
    {
        instance.StartCoroutine(instance.UploadNewHighscore(username, score));
    }
    //FIRST METHOD for upload on leaderboard
    IEnumerator UploadNewHighscore(string username, int score) {
        WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            print("Upload successiful");
            DownloadHighscores();
        }
        else print("Error uploading" + www.error);    
    }
    public void DownloadHighscores()
    {
        StartCoroutine("DownloadHighscoresFromDatabase");
    }
    IEnumerator DownloadHighscoresFromDatabase()
    {
        WWW www = new WWW(webURL + publicCode + "/pipe/");
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            FormatHighscores(www.text);
            highscoresDisplay.OnHighscoresDownloaded(highscoresList);
        }
        else print("Error downloading" + www.error);
    }
    void FormatHighscores(string textStream) {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new Highscore[entries.Length] ;
        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' } );
            string username = entryInfo[0];
            int score = int.Parse(entryInfo[1]);
            highscoresList[i] = new Highscore(username, score);
            print(highscoresList[i].username + ":" + highscoresList[i].score);
        }

    }
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {   
    }
}
public struct Highscore{
public string username;
public int score;
    public Highscore(string _username,int _score)
    {
        username = _username;
        score = _score;
    }
}
