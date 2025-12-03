using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject targetGameObject;
    public GameObject secondtargetGameObject;
    bool m_IsPlayerAtKey;


    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (m_IsPlayerAtKey)
        {

                        Debug.Log("This code Ran!");

            targetGameObject.SetActive(false);
                secondtargetGameObject.SetActive(false);


                

                gameObject.SetActive(false);
        }

        
    }
    
void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collected a Key!");

            m_IsPlayerAtKey = true;
        }
    }

/*
    void OnTriggerEnter (Collider other)
        {
            if (other.gameObject == player)
            {
                m_IsPlayerAtKey = true;
                
            }
        }
*/


    
}
