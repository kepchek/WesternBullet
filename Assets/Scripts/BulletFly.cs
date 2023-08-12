using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BulletFly : MonoBehaviour
{
 	private Rigidbody rb;

	private float xForce;
	private float zForce;
	private Vector3 force;
    public static float speed;
    public Vector3 direction;
    public static float sensivity;
	public GameObject EndScreen;
	public static int ShellCounter = 0;
	public GameObject MainBullet;
	public static AudioSource BulletSound;
	public AudioSource MoneySound;
	public AudioSource WinSound;
	public AudioSource MainSong;



	public float pitch =0.0F;
	public float yaw =0.0F;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		EndScreen.SetActive(false);
		//ShellCounter = 0;
		direction = new Vector3(0, 0, -1);	
		transform.Translate(speed*direction);
		speed = StartGame.ShellSpeed;
		sensivity = StartGame.Sens;
		BulletSound = GetComponent<AudioSource>();
		Time.timeScale = 1f;
	}

	

	void FixedUpdate (){

		pitch += Input.GetAxis ("Mouse X")*sensivity;
		yaw += Input.GetAxis ("Mouse Y")*sensivity;
		transform.Translate(speed*direction);


	}

	void LateUpdate(){
		// rotate object to face mouse direction
		rb.transform.localEulerAngles = new Vector3 (yaw, pitch, 0.0f);
        //transform.Translate(speed*direction);

	}


	private void OnTriggerEnter(Collider other) 
    {
		if(other.tag == "Let")
		{
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
		}
		if(other.tag == "Enemy")
		{
			EndScreen.SetActive(true);
			speed = 0;
			Time.timeScale = 0f;
			//EndRound.ShellsCount();
			BulletSound.Stop();
			MainSong.Stop();
			WinSound.Play();
		}
		if(other.tag == "Gold")
        {
            ShellCounter++;
            Destroy(other.gameObject);
			string textScore = System.Convert.ToString(ShellCounter);
			MoneySound.Play();
			//EndRound.ShellsCount();
        }
    }
}
