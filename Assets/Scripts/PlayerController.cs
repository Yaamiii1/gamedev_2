using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > +xRange)
        {
            transform.position = new Vector3(+15, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(projectilePrefab,transform.position + Vector3.right * 0.1f, transform.rotation);


        }
    }
}