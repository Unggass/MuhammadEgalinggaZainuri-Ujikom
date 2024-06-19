using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject foodPrefab;
    public GameObject pauseMenu;

    private Rigidbody rb;

    public float moveSpeed = 5.0f;

    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3 (horizontalInput, 0, 0) * Time.deltaTime * moveSpeed;

        transform.Translate(move);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
        
       if(Input.GetKeyDown(KeyCode.Escape) )
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
