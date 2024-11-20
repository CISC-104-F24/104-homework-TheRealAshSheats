using UnityEngine;
using UnityEngine.UI;  // Required for Image component
using TMPro; // Required for TextMeshPro support

public class Card : MonoBehaviour
{
    // Public variables for card data
    public int rank;  // The rank of the card
    public string suit;  // The suit of the card
    public Color backgroundColor;  // Background color of the card

    // Public variables for references to UI elements
    public TextMeshProUGUI rankDisplay; // The TextMeshPro component showing rank
    public TextMeshProUGUI suitDisplay; // The TextMeshPro component showing suit
    public Image cardBackground; // The Image component showing background color

    // Public reference to the suit icon image (to change based on suit)
    public Image suitIcon; // The Image component showing the suit icon

    // Public reference to suit images (for swapping)
    public Sprite spadeIcon;
    public Sprite heartIcon;
    public Sprite diamondIcon;
    public Sprite clubIcon;

    // Function to change the rank randomly
    public void RandomRank()
    {
        rank = Random.Range(1, 14); // Random rank from 1 to 13
        rankDisplay.text = rank.ToString();  // Update the displayed rank
        Debug.Log("Random Rank: " + rank);  // Log to console for debugging
    }

    // Function to change the suit randomly
    public void RandomSuit()
    {
        string[] suits = { "Spade", "Heart", "Diamond", "Club" };  // Available suits
        suit = suits[Random.Range(0, suits.Length)];  // Select a random suit
        //suitDisplay.text = suit;  // Update the displayed suit
        Debug.Log("Random Suit: " + suit);  // Log to console for debugging
        UpdateSuitIcon();  // Call function to change the suit icon based on selected suit
    }

    // Function to change the background color randomly
    public void RandomBackgroundColor()
    {
        backgroundColor = new Color(Random.value, Random.value, Random.value);  // Random RGB color
        cardBackground.color = backgroundColor;  // Apply the background color to the card
        Debug.Log("Random Background Color: " + backgroundColor);  // Log to console for debugging
    }

    // Function to increase the rank by 1
    public void IncreaseRank()
    {
        rank = Mathf.Min(rank + 1, 13);  // Increase rank by 1 but cap it at 13
        rankDisplay.text = rank.ToString();  // Update the displayed rank
        Debug.Log("Increased Rank: " + rank);  // Log to console for debugging
    }

    // Function to decrease the rank by 1
    public void DecreaseRank()
    {
        rank = Mathf.Max(rank - 1, 1);  // Decrease rank by 1 but keep it above 1
        rankDisplay.text = rank.ToString();  // Update the displayed rank
        Debug.Log(rank + "          " + rank );  // Log to console for debugging
    }

    // Function to change the suit (directly pick a suit)
    public void ChangeSuit(string newSuit)
    {
        suit = newSuit;  // Set the suit to the new suit
        //suitDisplay.text = suit;  // Update the displayed suit
        Debug.Log("Changed Suit to: " + suit);  // Log to console for debugging
        UpdateSuitIcon();  // Call function to update the suit icon
    }

    // Function to update the suit icon based on the current suit
    void UpdateSuitIcon()
    {
        // Based on the suit, change the sprite for the suit icon
        switch (suit)
        {
            case "Spade":
                suitIcon.sprite = spadeIcon;  // Set the suit icon to the spade icon
                break;
            case "Heart":
                suitIcon.sprite = heartIcon;  // Set the suit icon to the heart icon
                break;
            case "Diamond":
                suitIcon.sprite = diamondIcon;  // Set the suit icon to the diamond icon
                break;
            case "Club":
                suitIcon.sprite = clubIcon;  // Set the suit icon to the club icon
                break;
            default:
                Debug.LogWarning("Unknown suit: " + suit);
                break;
        }
    }
}
