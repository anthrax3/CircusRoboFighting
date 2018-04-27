using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

	[SerializeField]
	RectTransform ThrusterFuelFill;

    [SerializeField]
    RectTransform HealthBarFill;

    [SerializeField]
    Text AmmoText;

	[SerializeField]
	GameObject pauseMenu;

    [SerializeField]
    GameObject Scoreboard;

    private Player player;
    private PlayerController controller;
    private WeaponManager weaponManager;
    public void SetPlayer(Player _player)
    {
        player = _player;
        controller = player.GetComponent<PlayerController>();
        weaponManager = player.GetComponent<WeaponManager>();
    }

	void Start ()
	{
        PauseMenu.IsOn = false;
	}

    void Update()
    {
        SetFuelAmount(controller.GetThrusterFuelAmount());
        SetHealthAmount(player.GetHealthPct());
        SetAmmoAmount(weaponManager.GetCurrentWeapon().bullets);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Scoreboard.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            Scoreboard.SetActive(false);
        }
    }

	public void TogglePauseMenu ()
	{
		pauseMenu.SetActive(!pauseMenu.activeSelf);
        PauseMenu.IsOn = pauseMenu.activeSelf;
    }

    void SetFuelAmount(float _amount)
    {
        ThrusterFuelFill.localScale = new Vector3(1f, _amount, 1f);
    }

    void SetHealthAmount(float _amount)
    {
        HealthBarFill.localScale = new Vector3(1f, _amount, 1f);
    }

    void SetAmmoAmount(int _amount)
    {
        AmmoText.text = _amount.ToString();
    }

}
