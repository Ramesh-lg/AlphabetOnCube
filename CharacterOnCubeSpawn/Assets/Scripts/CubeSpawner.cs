using TMPro;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject cuberefab;
    [SerializeField] Transform spawnPos;

    private void Start()
    {
         cuberefab.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) CubeSpawn("A");
        if (Input.GetKeyDown(KeyCode.B)) CubeSpawn("B");

        if (Input.GetKeyDown(KeyCode.C))
        {
            CubeSpawn("C");
        }
    }
    /// <summary>
    /// Spawning cube and changing the string color randomly
    /// </summary>
    /// <param name="alphabet"></param>
    public void CubeSpawn(string alphabet)
    {
        GameObject tempCube = Instantiate(cuberefab, spawnPos) as GameObject;
        CharacterText characterGenerator = tempCube.GetComponent<CharacterText>();
        characterGenerator.charaterText.text = alphabet;
        characterGenerator.charaterText.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        Debug.Log("Text " + characterGenerator.charaterText.text);
    }
}
