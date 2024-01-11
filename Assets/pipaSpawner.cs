using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipaSpawner : MonoBehaviour
{
    public float starttime;
    public float MaxTime;
    public float Meight;
    public GameObject pipa;
    public AudioClip scoreSound;
    public float preparationTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (preparationTime > 0)
        {
            preparationTime -= Time.deltaTime;
            return;
        }
        if (starttime > MaxTime)
        {
            GameObject pipabaru = Instantiate(pipa);
            pipabaru.transform.position += new Vector3(0, Random.Range(-Meight, Meight), 0);
            starttime = 0;
        }
        starttime += Time.deltaTime;
        //SoundManager.instance.PlaySound(scoreSound);
    }
}
