using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

//Source file name:GameController
//Author’s name:Pranoy Anil
//Last Modified by:Pranoy Anil
//Date last Modified:1/3/16 
//Program description: GemHunt - Assignment 02

public class GameController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;


    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;



             
            this.Score.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.Lives.text = "Lives: " + this._livesValue;
            }
        }
    }

    // PUBLIC INSTANCE VARIABLES
    public Text Lives;
    public Text Score;
    public Text GameOver;
    public Text HighScore;
    public Button RestartButton;
    public PlayerController Player;
    

    // Use this for initialization
    void Start()
    {
        this._initialize();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //PRIVATE METHODS ++++++++++++++++++

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.GameOver.gameObject.SetActive (false);
        this.HighScore.gameObject.SetActive (false);
        this.RestartButton.gameObject.SetActive(false);
    }

    private void _endGame()
    {
        this.HighScore.text = "High Score: " + this._scoreValue;
       this.GameOver.gameObject.SetActive (true);
        this.HighScore.gameObject.SetActive (true);
        this.Lives.gameObject.SetActive(false);
        this.Score.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive (true);
        this.Player.gameObject.SetActive(false);
    }

    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
