using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PCScript : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 3f;
    public TextMeshProUGUI promptText;
    private bool canInteract = false;
    public bool emailDeleted = false;

    void Start()
    {
         if (promptText == null) {
        Debug.LogError("promptText is not assigned in the Inspector!");
        } else {
        promptText.gameObject.SetActive(true); 
         }
    }

    void Update() {
        // Calculate the distance between the player and the PC
        float distance = Vector3.Distance(player.position, transform.position);
        
        if (distance < detectionDistance && !emailDeleted)
        {
            // If the player is close enough and the email isn't deleted, show the prompt
            promptText.gameObject.SetActive(true);
            PCText();  // Update text here
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
            emailDeleted = true; // Mark email as deleted
            PCText(); // Update text after deleting email
        }

        void PCText()
        {
            if (!emailDeleted)
            {
                promptText.text = "Press space to delete email";
            }
            else
            {
                promptText.text = "Email deleted! Proceed back to start!";
            }
        }


    
}
