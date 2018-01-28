using UnityEngine;

public class Game : MonoBehaviour
{

    public PlayerMaskController playerMaskController;
    public Endscreen endscreen;
    static PlayerMaskController playerLight;

    static int collectedFlowers = 0;
    static Endscreen localEndscreen;
    public static PlayerMaskController PlayerLight { get { return playerLight; } }
    // Use this for initialization
    void OnEnable()
    {
        collectedFlowers = 0;
        playerLight = playerMaskController;
        localEndscreen = endscreen;
    }

    public static void CollectFlower()
    {
        collectedFlowers++;
        CheckVictory();

    }

    static void CheckVictory()
    {
        if (collectedFlowers == 7)
        {
            Win();
        }
    }

    static void Win()

    {
        localEndscreen.Show();
        Debug.Log("Ganaste");

    }
}
