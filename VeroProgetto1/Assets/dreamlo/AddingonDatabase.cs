using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingonDatabase : MonoBehaviour
{
    public void AddHighscore()
    {
        Highscores.AddNewHighscore(DBManager.username,DBManager.score);
        //precedente utilizzo
        /*if (PointsControllerActivator.points != 0 && PointsControllerActivator2.points==0 && PointsControllerActivator3.points==0) Highscores.AddNewHighscore(ProfileUse.profileName+"-level01", PointsControllerActivator.points);
        if (PointsControllerActivator.points != 0 && PointsControllerActivator2.points != 0&&PointsControllerActivator3.points==0) Highscores.AddNewHighscore(ProfileUse.profileName+"-level02", PointsControllerActivator.points+PointsControllerActivator2.points);
        if (PointsControllerActivator.points != 0 && PointsControllerActivator2.points != 0&&PointsControllerActivator3.points!=0) Highscores.AddNewHighscore(ProfileUse.profileName + "-Completed", PointsControllerActivator.points + PointsControllerActivator2.points+PointsControllerActivator3.points);*/
    }
}
