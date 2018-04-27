using UnityEngine;
using UnityEngine.UI;

public class PlayerNameplate : MonoBehaviour
{

    [SerializeField]
    private Text UsernameText;

    [SerializeField]
    private RectTransform HealthBarFill;

    [SerializeField]
    private Player player;

    // Update is called once per frame
    void Update()
    {
        UsernameText.text = player.username;
        HealthBarFill.localScale = new Vector3(player.GetHealthPct(), 1f, 1f);
    }

}