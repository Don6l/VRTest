using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxScript : MonoBehaviour
{
    [SerializeField] Material SkyboxOne;
    [SerializeField] Material SkyboxTwo;
    [SerializeField] Material SkyboxThree;

    private float skyBoxIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = SkyboxOne;
    }

    public void Click()
    {
        if (skyBoxIndex <= 2)
        {
            skyBoxIndex++;
        }
        else if (skyBoxIndex > 2)
        {
            skyBoxIndex = 0;
        }
        Debug.Log(skyBoxIndex);
        RenderSky(skyBoxIndex);
    }

    void RenderSky(float skyBoxIndex)
    {
        if(skyBoxIndex == 0)
        {
            RenderSettings.skybox = SkyboxOne;
        }
        else if(skyBoxIndex == 1)
        {
            RenderSettings.skybox = SkyboxTwo;
        }
        else if(skyBoxIndex == 2)
        {
            RenderSettings.skybox = SkyboxThree;
        }
    }
}
