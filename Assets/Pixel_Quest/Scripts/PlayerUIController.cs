using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUIController : MonoBehaviour
{

    public Image heartImage;
    private void Start()
    {
        heartImage = GameObject.Find("heart").GetComponent<Image>();
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;


        // Update is called once per frame
        void Update()
        {

        }
    }
}
