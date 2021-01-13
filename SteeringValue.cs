using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteeringValue : MonoBehaviour
{
	
	Text SValue;
	
	public GameObject SW;
	
    // Start is called before the first frame update
    void Start()
    {
        SValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        SValue.text = "Steering Value: " + SW.GetComponent<SteeringWheel>().GetClampedValue();
    }
}
