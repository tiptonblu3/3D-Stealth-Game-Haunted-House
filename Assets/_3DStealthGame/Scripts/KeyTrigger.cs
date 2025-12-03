using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject targetGameObject;
    public GameObject secondtargetGameObject;
    bool m_IsPlayerAtKey;
    public AudioSource audioSource;
    public AudioClip Dooropen;
    public float displayDuration = 1f;
    

    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         
    }
    

private void KeyCollect()
    {

        targetGameObject.SetActive(false);
            secondtargetGameObject.SetActive(false);

            

            gameObject.SetActive(false);

    }

void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            Invoke("KeyCollect", displayDuration);
        }
    }



    
}
