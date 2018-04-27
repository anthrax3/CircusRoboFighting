using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreboardItem : MonoBehaviour
{

    [SerializeField]
    Text UsernameText;

    [SerializeField]
    Text KillsText;

    [SerializeField]
    Text DeathsText;

    public void Setup(string username, int kills, int deaths)
    {
        UsernameText.text = username;
        KillsText.text = "Kills: " + kills;
        DeathsText.text = "Deaths: " + deaths;
    }

}
