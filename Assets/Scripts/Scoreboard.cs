using UnityEngine;
using System.Collections;

public class Scoreboard : MonoBehaviour
{

    [SerializeField]
    GameObject PlayerScoreboardItem;

    [SerializeField]
    Transform PlayerScoreboardList;

    void OnEnable()
    {
        Player[] players = GameManager.GetAllPlayers();

        foreach (Player player in players)
        {
            GameObject itemGO = (GameObject)Instantiate(PlayerScoreboardItem, PlayerScoreboardList);
            PlayerScoreboardItem item = itemGO.GetComponent<PlayerScoreboardItem>();
            if (item != null)
            {
                item.Setup(player.username, player.kills, player.deaths);
            }
        }
    }

    void OnDisable()
    {
        foreach (Transform child in PlayerScoreboardList)
        {
            Destroy(child.gameObject);
        }
    }

}
