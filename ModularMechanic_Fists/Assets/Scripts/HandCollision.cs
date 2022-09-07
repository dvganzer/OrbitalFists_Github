using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandCollision : MonoBehaviour
{
    
    public float score;
    public Text scoreText;
    void Update()
    {
        scoreText.text = score.ToString();

        if(score == 6)
        {
            SceneManager.LoadScene(0);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Block"))
        {
            Destroy(collision.gameObject);
            ++score;
        }
    }
}
