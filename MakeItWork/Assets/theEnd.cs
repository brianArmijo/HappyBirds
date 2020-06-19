using UnityEngine.SceneManagement;
using UnityEngine;

public class theEnd : MonoBehaviour
{

    private float _timeSittingAround;



    // Update is called once per frame
    void Update()
    {
        _timeSittingAround += Time.deltaTime;

        if
                    (_timeSittingAround > 3)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Scenes/MainMenu");

        }
    }
}