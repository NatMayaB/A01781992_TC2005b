using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    [SerializeField] TMP_Text  tmpObj;
    [SerializeField] int maxScore;
    CreateBalls  creator;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
    creator = GetComponent<CreateBalls>();
    score = 5;
}

// Update is called once per frame
public void OnTriggerEnter2D(Collider2D collision)
{ 
    if(collision.gameObject.CompareTag("person")) {
        Destroy(collision.gameObject);
        score--;
        tmpObj.text = "Life's: " + score;
        Invoke("out_of_lives", 0f);
        }

        } 

        private void out_of_lives() {
            if (score == 0) {
                SceneManager.LoadScene("gameOver");
            }
        }
    }
