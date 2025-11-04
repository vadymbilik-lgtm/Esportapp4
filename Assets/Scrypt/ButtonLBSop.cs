using UnityEngine;

public class ButtonLBSop
{
    public string url = "https://lbs.se/stockholmnorra/"; // LBS webb sida  

    public void OpenGymWebsite()
    {
        Application.OpenURL(url);
    }
}
