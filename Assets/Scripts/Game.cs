using UnityEngine;

public class Game : MonoBehaviour {

    public PlayerMaskController playerMaskController;

    static PlayerMaskController playerLight;
    public static PlayerMaskController PlayerLight { get { return playerLight; } }
	// Use this for initialization
	void OnEnable () {
        playerLight = playerMaskController;
	}
}
