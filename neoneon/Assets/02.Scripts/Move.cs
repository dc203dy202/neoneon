using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Joystick joystick;
	public float speed;

	public void Update()
	{
		JoystickControl();
	}

	public void JoystickControl()
	{

		if (joystick.Vertical > 0)
		{
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		else if (joystick.Vertical < 0)
		{
			this.transform.Translate(Vector3.forward * -speed * Time.deltaTime);
		}
		
		
	}
}
