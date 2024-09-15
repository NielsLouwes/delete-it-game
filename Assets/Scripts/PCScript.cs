using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PCScript : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 2f;
    public TextMeshProUGUI promptText;
    private bool canInteract = false;
    private bool emailDeleted = false;

    void Start()
    {
        // Hide the text prompt initially
        promptText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Calculate the distance between the player and the PC
        float distance = Vector3.Distance(player.position, transform.position);
        
        if (distance < detectionDistance && !emailDeleted)
        {
            // If the player is close enough and the email isn't deleted, show the prompt
            promptText.gameObject.SetActive(true);
            canInteract = true;
        }
        else
        {
            // Otherwise, hide the prompt and prevent interaction
            promptText.gameObject.SetActive(false);
            canInteract = false;
        }

        // Only allow interaction if the player can interact and hasn't deleted the email
        if (canInteract && Input.GetKeyDown(KeyCode.Space) && !emailDeleted)
        {
            DeleteEmail();
        }
    }

    void DeleteEmail()
    {
        Debug.Log("Email Deleted!");
        promptText.gameObject.SetActive(false);
        emailDeleted = true; // Mark email as deleted
    }
}
