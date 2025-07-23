using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;
    public int Health = 3;
    public int coinCount = 0;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                {
                    respawnPoint.position = collision .transform.Find ("Point").position;
                    break;
                }
            case "Death":
                { 

                    
                    if (Health <= 0)
                    {
                        string ThisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(ThisLevel);


                        
                            
                    }

                    else
                    {
                        transform.position = respawnPoint.position;
                    }
                        break;
                    
                }

            case "Finish":
                {
                    string nextLevel = collision.GetComponent<LevelGoal>().Nextlevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    Health++;
                    Destroy(collision.gameObject);
                    break;
                }

        }
                
        }

    }

