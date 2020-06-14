using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour
{

    private const string defaultScoreText = "Distance: ";
    public Transform player;
    public Text distanceScoreText;
    

    void Update()
    {
        distanceScoreText.text = defaultScoreText + player.position.z.ToString("0");
        distanceScoreText.resizeTextForBestFit = true;
    }
}
