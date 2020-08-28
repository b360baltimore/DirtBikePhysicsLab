using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ControlPanelUI : MonoBehaviour
{
    public Bike bike;
    public bool enableSetPosition = false;
    public TMPro.TMP_InputField positionText;
    public TMPro.TMP_InputField velocityText;
    public TMPro.TMP_Text timeText;
    private float elapsedTime = 0f;
    private float startPos;


    // Start is called before the first frame update
    void Start()
    {
        ResetSimulation();
        SetBikeVelocity();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (bike.isRunning)
        {
            elapsedTime += Time.deltaTime;
            timeText.text = elapsedTime.ToString("0.00");
            UpdateBikePositionText();
        }        
    }

    /// <summary>
    /// Sets the bikes x-position to be the value in the GUI
    /// </summary>
    public void SetBikePosition()
    {
        //bike.transform.position 
        //    = new Vector3(
        //        Single.Parse(positionText.text), 
        //        bike.transform.position.y, 
        //        bike.transform.position.z);
    }

    /// <summary>
    /// Sets the position text to be the x-position of the bike
    /// </summary>
    public void UpdateBikePositionText()
    {
        positionText.text = bike.transform.position.x.ToString("0.0");
    }

    /// <summary>
    /// Sets the bike's velocity to the value in the GUI
    /// </summary>
    public void SetBikeVelocity()
    {
        float vel;
        bool isFloat = float.TryParse(velocityText.text, out vel);
        if (isFloat)
        {
            bike.velocity = vel;
        }
        else
        {
            velocityText.text = "0";
        }
        
    }

    /// <summary>
    /// Places the bike back at the zero mark
    /// </summary>
    public void ResetSimulation()
    {
        bike.transform.position = new Vector3(0f, 0f, 0f);
        bike.isRunning = false;
        elapsedTime = 0f;
        timeText.text = elapsedTime.ToString("0.00");
        positionText.text = "0.0";
    }

    /// <summary>
    /// Starts the bike moving and starts the timer
    /// </summary>
    public void StartSimulation()
    {
        bike.isRunning = true;
        startPos = bike.transform.position.x;
    }

    public void PauseSimulation()
    {
        bike.isRunning = false;
    }
}
