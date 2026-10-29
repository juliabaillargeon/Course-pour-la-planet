using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int count = 0;
    public GameObject legend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }

        if (count >= 1)
        {
            Destroy(legend);
        }
    }
}
