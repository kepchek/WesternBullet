using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class BulletFly : MonoBehaviour
{
 	private Rigidbody rb;

	[Header("Control Info")]
    	public static float speed;
    	public Vector3 direction;
    	public static float sensivity;
		//public JoystickMovement joystick;
		public VariableJoystick MoveJoystick;
		public GameObject KostylJoystick;
		public static bool IsWin;
	
	[Header("GameObj")]
		public GameObject EndScreen;
		public static int ShellCounter = 0;
		public GameObject MainBullet;
		public GameObject PauseTrigger;
		public GameObject SoundManager;

	[Header("Sound")]
		public static AudioSource BulletSound;
		public AudioSource MoneySound;
		public AudioSource WinSound;



	public float pitch =0.0F;
	public float yaw =0.0F;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		EndScreen.SetActive(false);
		direction = new Vector3(0, 0, -1);	
		transform.Translate(speed*direction);
		speed = StartGame.ShellSpeed;
		sensivity = StartGame.Sens;
		BulletSound = GetComponent<AudioSource>();
		Time.timeScale = 1f;
		IsWin = false;
	}

	

	void FixedUpdate (){
		
		//PC Controls
		// pitch += Input.GetAxis ("Mouse X")*sensivity;
		// yaw += Input.GetAxis ("Mouse Y")*sensivity;


		//Mobile Controls
		pitch += MoveJoystick.Horizontal * sensivity;
		yaw += MoveJoystick.Vertical * sensivity;

		//Move object to direction
		transform.Translate(speed*direction);

		// rotate object to face mouse direction
		rb.transform.localEulerAngles = new Vector3 (yaw, pitch, 0.0f);

	}


	private void OnTriggerEnter(Collider other) 
    {
		if(other.tag == "Let")//Lose event
		{
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
		}
		if(other.tag == "Enemy")//Victory event
		{
			LvlControl.instance.isEndGame();
			EndScreen.SetActive(true);
			KostylJoystick.SetActive(false);
			PauseTrigger.SetActive(false);
			speed = 0;
			Time.timeScale = 0f;
			BulletSound.Stop();
			WinSound.Play();
			IsWin = true;//Allow delete soundManager
		}
		if(other.tag == "Gold")//Money take event
        {
            ShellCounter++;
            Destroy(other.gameObject);
			string textScore = System.Convert.ToString(ShellCounter);
			MoneySound.Play();
        }
    }
}
