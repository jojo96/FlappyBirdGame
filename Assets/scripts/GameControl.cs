using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameControl : MonoBehaviour
{
	
	private int score = 0;
	public static GameControl instance;
	public Text ScoreText;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float ScrollSpeed = -1.5f;
    // Start is called before the first frame update
    void Awake()
    {
		if(instance == null)
			instance = this;
		else if (instance != this)
				Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButton(0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
	
	public void BirdScored(){
		if(gameOver)
			return;
		score++;
		ScoreText.text = "Score: "+ score.ToString();
		
	}
	
	public void BirdDied(){
		gameOverText.SetActive(true);
		gameOver = true;
	}
}
