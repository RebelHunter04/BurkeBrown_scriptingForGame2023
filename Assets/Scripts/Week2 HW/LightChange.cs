using UnityEngine;

public class LightChange : MonoBehaviour
{
    public Light lightWeChange;
    public Vector3 lightMoveDirection;
    public bool yesOrNo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightWeChange.color = Color.green;
        this.gameObject.SetActive(false);
        lightWeChange.gameObject.SetActive(false);

        //destroy(lightWeChange)
    }

    // Update is called once per frame
    void Update()
    {
        //AdjustLight();
        Debug.Log("Light object has been adjusted");

        lightWeChange.transform.position += lightMoveDirection * Time.deltaTime;
        lightWeChange.intensity += 40f * Time.deltaTime;
        lightWeChange.spotAngle += 10f * Time.deltaTime;

        
    }

    //public void ChangeLightColor(Color santaClaus);

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        //run when object is disabled, run here before disabled
    }

    private void Awake()
    {
        //called before start
    }

    private void OnDestroy()
    {

    }
}
