using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killfeed : MonoBehaviour {

    [SerializeField]
    GameObject KillfeedItemPrefab;

    // Use this for initialization
    void Start()
    {
        GameManager.instance.onPlayerKilledCallback += OnKill;
    }

    public void OnKill(string player, string source)
    {
        GameObject go = (GameObject)Instantiate(KillfeedItemPrefab, this.transform);
        go.GetComponent<KillfeedItem>().Setup(player, source);

        Destroy(go, 4f);
    }
}
