using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
     public void PlayEnding() {

        SceneManager.LoadSceneAsync(2);
    }
}
