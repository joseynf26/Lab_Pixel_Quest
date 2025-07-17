using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "scene_2";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string ThisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(ThisLevel);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }

    }
}
