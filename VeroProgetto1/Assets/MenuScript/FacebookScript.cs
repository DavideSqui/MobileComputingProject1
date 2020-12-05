using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FacebookScript : MonoBehaviour
{

    public Text FriendsText;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                    FB.ActivateApp();
                else
                    Debug.LogError("Couldn't initialize");
            },
            isGameShown =>
            {
                if (!isGameShown)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            });
        }
        else
            FB.ActivateApp();
    }

    #region Login / Logout
    public void FacebookLogin()
    {
        var permissions = new List<string>() { "public_profile", "email", "user_friends" };
        FB.LogInWithReadPermissions(permissions);
    }

    public void FacebookLogout()
    {
        FB.LogOut();
    }
    #endregion

    public void FacebookShare()
    {
        FB.ShareLink(new System.Uri("https://www.facebook.com/photo/?fbid=117349796855689&set=a.117349813522354"), "Check it out!",
            "Great game!",
            new System.Uri("https://www.facebook.com/photo/?fbid=117349796855689&set=a.117349813522354"));
    }

    #region Inviting
    public void FacebookGameRequest()
    {
        FB.AppRequest("Hey! Come and play this awesome game!", title: "Adventure1");
    }

   /* public void FacebookInvite()
    {
        no facebook invite
       FB.Mobile.AppInvite(new System.Uri("https://play.google.com/store/apps/details?id=com.tappybyte.byteaway"));
    }*/
    #endregion

    public void GetFriendsPlayingThisGame()
    {
        string query = "/me/friends";
        FB.API(query, HttpMethod.GET, result =>
        {
            var dictionary = (Dictionary<string, object>)Facebook.MiniJSON.Json.Deserialize(result.RawResult);
            var friendsList = (List<object>)dictionary["data"];
            FriendsText.text = string.Empty;
            foreach (var dict in friendsList)
                FriendsText.text += ((Dictionary<string, object>)dict)["name"];
        });
    }
    //Metodi per lo share dei punti 
    public void FacebookSharePoints1()
    {
       FB.FeedShare("100057420076794", new System.Uri("https://www.facebook.com/photo/?fbid=117349796855689&set=a.117349813522354"), "Check out my new Score on Level 1: " + PointsControllerActivator.points, "Enjoy this free game, challenge yourself or share with friends and challenge them.", "This is a free game",new System.Uri("https://unsplash.com/photos/p0j-mE6mGo4"));   
    }

        public void FacebookSharePoints2()
    {
        FB.FeedShare("100057420076794", new System.Uri("https://www.facebook.com/photo/?fbid=117349796855689&set=a.117349813522354"), "Check out my new Score on Level 2: " + PointsControllerActivator.points, "Enjoy this free game, challenge yourself or share with friends and challenge them.", "This is a free game", new System.Uri("https://unsplash.com/photos/p0j-mE6mGo4"));
    }
}