using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
    private float fallDelay = 1f;
    private float appearDelay = 2f;
    private float destroyDelay = 2f;
    private Vector2 defaultPos;

    [SerializeField] private Rigidbody2D rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultPos = gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlatformDrop(1f, 3f));
        }
    }

    private IEnumerator PlatformDrop(float timeUntilDisappear, float timeUntilRespawn)
    {
        Debug.Log(defaultPos);
        yield return new WaitForSeconds(timeUntilDisappear);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(timeUntilRespawn);
        Reset();
    }

    private void Reset()
    {
        rb.bodyType = RigidbodyType2D.Static;
        gameObject.transform.position = defaultPos;
    }
}
