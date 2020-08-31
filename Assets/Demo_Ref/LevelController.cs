using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] Light _lightObject = null;
    [SerializeField] float _rangeIncrement = .2f;
    [SerializeField] SceneLoader _sceneLoader = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _sceneLoader.ReloadLevel();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomizeColor();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            IncreaseRange(_rangeIncrement);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DecreaseRange(_rangeIncrement);
        }
    }

    void IncreaseRange(float increaseAmount)
    {
        _lightObject.range += increaseAmount;
    }

    void DecreaseRange(float decreaseAmount)
    {
        _lightObject.range -= decreaseAmount;
    }

    void RandomizeColor()
    {
        // decide random color values (R,G,B). Use f for float
        // Color class takes 0-1, NOT 0-255
        float randomR = UnityEngine.Random.Range(0, 1f);
        float randomG = UnityEngine.Random.Range(0, 1f);
        float randomB = UnityEngine.Random.Range(0, 1f);
        // alpha 0-1 is how opaque. Leave at 1 for no transparency
        // create the new color based on values
        Color newColor = new Color(randomR, randomG, randomB, 1);
        Debug.Log(newColor);
        // change the light color
        _lightObject.color = newColor;
    }
}
