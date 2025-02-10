using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeLightColor(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeLightColor(Color.blue);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeLightColor(Color.green);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lightChange.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            lightChange.gameObject.SetActive(true);
        }
    }
    public void ChangeLightColor(Color tank)
    {
        lightChange.color = tank;
    }
}
