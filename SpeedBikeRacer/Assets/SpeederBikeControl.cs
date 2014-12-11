using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class SpeederBikeControl : MonoBehaviour
{
  Rigidbody speeder_body;
  float m_deadZone = 0.1f;

  public GUIText powerUpName;
  public GUIText sheild;

  public float hoverForce = 9.0f;
  public float hoverHeight = 2.0f;
  public GameObject[] hoverPoints;

  public float forwardAcl = 100.0f;
  public float backwardAcl = 25.0f;
  float currentThrust = 0.0f;
  float breaking = 0.0f;

  public float turnStrength = 10f;
  float currentTurn = 0.0f;

  public GameObject leftAirBrake;
  public GameObject rightAirBrake;

  int layerMask;
  int powerUp = 0;
  int sheildPercent = 0;

  void Start()
  {
    speeder_body = GetComponent<Rigidbody>();

    layerMask = 1 << LayerMask.NameToLayer("Characters");
    layerMask = ~layerMask;

      sheild.text = "Sheild: " + sheildPercent + "%";
  }

  void OnDrawGizmos()
  {

    //  Hover Force
    RaycastHit hit;

    for (int i = 0; i < hoverPoints.Length; i++)
    {
      var hoverPoint = hoverPoints [i];
      if (Physics.Raycast(hoverPoint.transform.position, -Vector3.up, out hit, hoverHeight, layerMask))
      {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(hoverPoint.transform.position, hit.point);
        Gizmos.DrawSphere(hit.point, 0.5f);
      } 
      else
      {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(hoverPoint.transform.position, hoverPoint.transform.position - Vector3.up * hoverHeight);
      }
    }
  }
	
  void Update()
  {
    currentThrust = 0.0f;
    currentTurn = 0.0f;

    float aclAxis = Input.GetAxis("Vertical");
    float turnAxis = Input.GetAxis("Horizontal");

    // Main Thrust  
    if (aclAxis > m_deadZone)
    {
        currentThrust = aclAxis * forwardAcl;
    }
    else if (aclAxis < -m_deadZone)
    {
        currentThrust = aclAxis * backwardAcl;
    }
    else
    {
        // User is not accelerating
    }

    // Turning
    if (Mathf.Abs(turnAxis) > m_deadZone)
    {
        currentTurn = turnAxis;
    }

     /* if(Input.GetKeyDown(KeyCode.Space))
      {
          breaking -= 10000;
      }*/
      if(Input.GetKey(KeyCode.E) && powerUp != 0)
      {
          if (powerUp == 1)
          {
              sheildPercent = 100;
              sheild.text = "Sheild: " + sheildPercent + "%";
              powerUp = 0;
          }
          else if (powerUp == 2)
          {
              forwardAcl = forwardAcl * 2;
              powerUp = 0;
          }
          else
          {
              GetRandomPowerUp();
          }
      }
  }

  void FixedUpdate()
  {

    //  Hover Force
    RaycastHit hit;

    for (int i = 0; i < hoverPoints.Length; i++)
    {
      var hoverPoint = hoverPoints [i];
      if (Physics.Raycast(hoverPoint.transform.position, -Vector3.up, out hit, hoverHeight, layerMask))
      {
          speeder_body.AddForceAtPosition(Vector3.up * hoverForce * (1.0f - (hit.distance / hoverHeight)), hoverPoint.transform.position);
      }
      else
      {
          if (transform.position.y > hoverPoint.transform.position.y)
          {
              speeder_body.AddForceAtPosition(hoverPoint.transform.up * hoverForce, hoverPoint.transform.position);
          }
          else
          {
              speeder_body.AddForceAtPosition(hoverPoint.transform.up * -hoverForce, hoverPoint.transform.position);
          }
      }
    }

    // Forward
    if (Mathf.Abs(currentThrust) > 0)
    {
        speeder_body.AddForce(transform.forward * currentThrust);
    }

    // Turn
    if (currentTurn > 0)
    {
        speeder_body.AddRelativeTorque(Vector3.up * currentTurn * turnStrength);
    }
    else if (currentTurn < 0)
    {
        speeder_body.AddRelativeTorque(Vector3.up * currentTurn * turnStrength);
    }
    else
    {
        //Do nothing, the user is not turning
    }
  }

  void OnTriggerEnter(Collider other)
  {
      if (other.gameObject.tag == "PowerUp")
      {
          other.gameObject.SetActive(false);
          GetRandomPowerUp();
      }
  }

  void GetRandomPowerUp()
  {
      powerUp = UnityEngine.Random.Range(0, 4);
      showPowerUpOnHUD();
  }

  void showPowerUpOnHUD()
  {
      if (powerUp == 0)
      {
          powerUpName.text = "";
      }
      else if (powerUp == 1)
      {
          powerUpName.text = "Available PowerUp: Sheild";
      }
      else if (powerUp == 2)
      {
          powerUpName.text = "Available PowerUp: SpeedBoost";
      }
      else if (powerUp == 3)
      {
          powerUpName.text = "Available PowerUp: Decrease Time";
      }
      else
      {
          powerUpName.text = "Available PowerUp: Random PowerUp";
      }
  }
}
