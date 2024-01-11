using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birthjump : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    public GameController gc;

    //game object
    public GameObject Player;
    public GameObject pipa;
    //public GameObject ground;

    //game audio
    public AudioClip jumpSound;
    public AudioClip gameOverSound;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * force;
            SoundManager.instance.PlaySound(jumpSound);
            if (ScoreManagement.Score >= 20)
            {
                HandleWin();
            }
        }
    }

    void HandleWin()
{
    // Tambahkan logika atau tindakan yang sesuai saat menang
    Debug.Log("Player wins!");
    // Misalnya, Anda bisa menampilkan pesan kemenangan atau memulai adegan kemenangan.
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            if (gc != null)
            {
                gc.gameOver();
                SoundManager.instance.PlaySound(gameOverSound);
            }
        }
        if (collision.gameObject.CompareTag("ground"))
        {
            if (gc != null)
            {
                gc.gameOver();
                SoundManager.instance.PlaySound(gameOverSound);
            }
        }


    }

}
