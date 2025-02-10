using UnityEngine;

public class reference : MonoBehaviour
{
    public Ned nedController; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nedController.scaleIncrease = 8f;
        nedController.Rotatened();
        nedController.Resetned();   
        nedController.Rotatened();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
