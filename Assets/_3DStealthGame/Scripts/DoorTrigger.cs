using UnityEngine;
using TMPro; 

public class CollisionTextController : MonoBehaviour
{
    public TextMeshProUGUI collisionText; 
    public float displayDuration = 1f;
    public AudioSource DoorOpen;


    void Start()
    {
        if (collisionText != null)
        {
            collisionText.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision) 
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (collisionText != null)
            {
                collisionText.gameObject.SetActive(true); 
            }
        }
    }

    void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collisionText != null)
            {
                Invoke("HideText", displayDuration);
                
            }
        }
    }
    private void HideText()
    {

        collisionText.gameObject.SetActive(false); 

    }
}