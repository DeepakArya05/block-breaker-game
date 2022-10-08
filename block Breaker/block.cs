using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Block : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;
    [SerializeField] GameObject blockSparklesVFX;
    [SerializeField] int maxHits;
    [SerializeField] int timeHits;//for display how many time hit (debuging purpose only)
    [SerializeField] Sprite[] hitSprite;
    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.CountBlock();
        }
        // FindObjectOfType<GameStatus>().AddToScore();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            timeHits++;
            if (timeHits >= maxHits)
            {
                Destroyblock();
            }
            else
            {
                int spriteIndex = timeHits - 1;
                GetComponent<SpriteRenderer>().sprite = hitSprite[spriteIndex];
            }
        }
    }
    private void Destroyblock()
    {
        Destroy(gameObject);
        level.BlockDestroyed();
        gameStatus = FindObjectOfType<GameStatus>();
        gameStatus.AddToScore();
        triggerSparklesVFX();
    }
    private void triggerSparklesVFX()
    {
        GameObject Sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
    }
    

    // Update is called once per frame
    void Update()
    {
        //gameStatus.AddScore();
    }
}
