using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscreen : MonoBehaviour {

    public void Show() {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<AudioSource>().Play();
        Invoke("LoadMenu", 16f);
    }

    void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }
}
