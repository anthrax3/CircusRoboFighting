using UnityEngine;

[System.Serializable]   // very important in unity to can deal with variable in other location 
public class PlayerWeapon {

    public string name = "Glock";

    public int Damage = 10;
    public float Range = 100f;

    public float fireRate = 0f;

    public int maxBullets = 20;
    [HideInInspector]
    public int bullets;

    public float reloadTime = 1f;

    public GameObject graphics;

    public PlayerWeapon()
    {
        bullets = maxBullets;
    }
}
