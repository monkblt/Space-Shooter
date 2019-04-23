using System.Collections;
using UnityEngine;

public class Stars : MonoBehaviour
{
    private ParticleSystem ps;
    private float hSliderValue = 1.0F;

    private GameController gameControllerObj;

    void Start()
    {
        gameControllerObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        ps = GetComponent<ParticleSystem>();  
    }

    void Update()
    {
        var main = ps.main;
        main.simulationSpeed = hSliderValue;

        if(gameControllerObj.winCondition == true)
        {
            if (hSliderValue <= 20)
            {
                hSliderValue += Time.deltaTime;
            }
        }
    }
}
