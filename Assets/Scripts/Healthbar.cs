using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(int health)
    {
        slider.value = health; 
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health; 
    }
}
