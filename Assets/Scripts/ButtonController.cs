using TMPro;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    TMP_Text textArea;
    public GameObject textAreaPrefab;
    public int randomLiczba = 0;
    [SerializeField] Transform spawnPoint;

    private void Awake()
    {
        textArea = textAreaPrefab.GetComponentInChildren<TMP_Text>();
    }

    void ChangeText(string newText)
    {
        textArea.text = newText;
    }

    public void GenerateRandomNumber()
    {
        SpawnPrefab();
        randomLiczba = Random.Range(1, 10);
        ChangeText(randomLiczba.ToString());
    }

    void SpawnPrefab()
    {
        if (textAreaPrefab != null)
        {
            Instantiate(textAreaPrefab, spawnPoint);
        }
        else
        {
            Debug.LogWarning("No prefab found");
        }
    }
}
