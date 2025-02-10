using UnityEngine;

public class Ned : MonoBehaviour
{
    public GameObject ned;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;
    public Transform teleportTransform;
    public Vector3 rotationAmount;
  
    // Update is called once per frame
    void Update()
    {
        ned.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
        if (ned.transform.localScale.x > 30)
        {
            youDiedScreen.SetActive(true);
        }
    }

    public void Resetned()
    {
        ned.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }
    public void Rotatened()
    {
        ned.transform.Rotate(new Vector3(0f, 0f, -90f));
        ned.transform.Rotate(rotationAmount);
    }
    public void Teleportned()
    {
        ned.transform.position = teleportTransform.position;
    }
   
}
