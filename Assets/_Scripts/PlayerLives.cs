using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public GameObject gameButtons;
    public TextMeshProUGUI hitsLeftGT;
    public GameObject boomPrefab;
    public GameObject hitPrefab;


    void Start()
    {
        GameObject hitsLeftGO = GameObject.Find("DownPlayerLivesLeft");
        hitsLeftGT = hitsLeftGO.GetComponent<TextMeshProUGUI>();
        hitsLeftGT.text = "3";
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
