using UnityEngine;
public class Wobble : MonoBehaviour
{
    public Material mat; // drag your material here in the inspector

    private float matSpeed;
    private float matIntensity;
    public float increment = 0.01f;  // how much to add/subtract each press
    private void Start()
    {
        matSpeed = mat.GetFloat("_Speed");
        matIntensity = mat.GetFloat("_Intensity");
    }
    void Update()
    {
        // Press the 1 key to increase both values
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            matSpeed += increment; //get the new current/new value and add increment amount to speed
            matIntensity += increment; //get the new current/new value and add increment amount to intensity

            mat.SetFloat("_Speed", matSpeed); //set the value
            mat.SetFloat("_Intensity", matIntensity);
        }

        //Press the 2 key to decrease both value
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            matSpeed -= increment; //get the new current/new value and minus increment amount to speed
            matIntensity -= increment; //get the new current/new value and minus increment amount to intensity

            mat.SetFloat("_Speed", matSpeed); //set the value
            mat.SetFloat("_Intensity", matIntensity);
        }
    }
}
