using UnityEngine;
using System.Collections;

public class Rotator1 : MonoBehaviour {
	
    private string gameState;

    public float originalX = 100;
    public float originalZ = 100;
    public float originalY = 100;

	// Use this for initialization
	void Start () {
		InvokeRepeating("ChangePosition1", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
			transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
	}

    void ChangePosition1()
    {

        float rand = UnityEngine.Random.Range(0, 4);
        Vector3 position;

        if (rand <= 1)
        {
            position = new Vector3(originalX, originalY, originalZ);
        }
        else if (rand <= 2)
        {
            position = new Vector3(originalX - 10, originalY, originalZ);
        }
        else if (rand <= 3)
        {
            position = new Vector3(originalX + 10, originalY, originalZ);
        }
        else if (rand <= 4)
        {
            position = new Vector3(originalX, originalY, originalZ + 10);
        }
        else
        {
            position = new Vector3(originalX, originalY, originalZ - 10);
        }

        rigidbody.MovePosition(position);
    }
}
