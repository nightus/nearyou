using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

    
    public bool doMovement = true;
    public float scrollSpeed = 5f;

    // BLOKADA SCROLLA GORA DOL
    public float minY = 10f;
    public float maxY = 80f; 

    // PREDKOSC PORUSZANIA SIE KAMERY I GRANICA WYCHWYTYWANIA
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;



	// Update is called once per frame
	void Update ()
    {
        // ESCAPE BY ZABLOKOWAC RUCH 
        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;

        if (!doMovement)
        {
            return;
        }
        // KONIEC BLOKADY ESCAPE




        // RUCH W DOL 
	    if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness )
        {
            new Vector3(0f, 0f, panSpeed );
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        // RUCH W GORE 
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            new Vector3(0f, 0f, panSpeed);
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        // RUCH W lewo 
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            new Vector3(0f, 0f, panSpeed);
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        // RUCH W prawo
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            new Vector3(0f, 0f, panSpeed);
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }


        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pozycja = transform.position;
        pozycja.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pozycja.y = Mathf.Clamp (pozycja.y, minY, maxY);


        transform.position = pozycja;


    }
}
