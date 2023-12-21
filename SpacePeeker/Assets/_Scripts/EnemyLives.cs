using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnemyLives : MonoBehaviour
{
    public int lives = 0;
    public int sc = 0;
    public TextMeshProUGUI gotScore;
    public GameObject gameButtons;
    public TextMeshProUGUI hitsLeftGT;
    public GameObject boomPrefab;
    public GameObject hitPrefab;


    void Start()
    {
        GameObject hitsLeftGO = GameObject.Find("UpEnemyLivesLeft");
        hitsLeftGT = hitsLeftGO.GetComponent<TextMeshProUGUI>();
        hitsLeftGT.text = "15";

        GameObject score = GameObject.Find("Score");
        gotScore = score.GetComponent<TextMeshProUGUI>();
        gotScore.text = "0";
    }


    void Update()
    {   
        if (Input.GetButtonDown("Fire1") && Time.timeScale != 0)
        {
            int scoreEarned = int.Parse(gotScore.text);
            sc -= 5;
            scoreEarned = sc;
            gotScore.text = scoreEarned.ToString();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);

            int lifes = int.Parse(hitsLeftGT.text);
            lives -= 1;
            lifes = lives;
            hitsLeftGT.text = lifes.ToString();
            
            int scoreEarned = int.Parse(gotScore.text);
            sc += 100;
            scoreEarned = sc;
            gotScore.text = scoreEarned.ToString();

            Vector3 myVector1 = new Vector3(0.0f, 0.0f, 0.0f);
            GameObject egg2 = Instantiate<GameObject>(hitPrefab);
            egg2.transform.position = transform.position + myVector1;

            if (lives <= 0)
            {
                Destroy(gameObject);
                Vector3 myVector = new Vector3(0.0f, 0.0f, 0.0f);
                GameObject egg = Instantiate<GameObject>(boomPrefab);
                egg.transform.position = transform.position + myVector;
                gameButtons.SetActive(true);
            }
        }
    }
}
