using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public PlayerMovement Player;

	public Transform player;
	public Text scoreText;
	
	void Start(){
		Player = FindObjectOfType<PlayerMovement>();
	}

	// Update is called once per frame
	void Update () {
		

		scoreText.text = "Score : "+ Player.points;
	}
}


