using System.Collections;
using TMPro;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject cuberefab;
    [SerializeField] Transform spawnPos;
    public float destroyAfterSeconds = 25f;

    private void Start()
    {
         cuberefab.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) { StartCoroutine(CubeSpawn("A")); }
        if (Input.GetKeyDown(KeyCode.B)) StartCoroutine(CubeSpawn("B"));
        if (Input.GetKeyDown(KeyCode.C)) StartCoroutine(CubeSpawn("C"));
        if (Input.GetKeyDown(KeyCode.D)) StartCoroutine(CubeSpawn("D"));
        if (Input.GetKeyDown(KeyCode.E)) StartCoroutine(CubeSpawn("E"));
        if (Input.GetKeyDown(KeyCode.F)) StartCoroutine(CubeSpawn("F"));
        if (Input.GetKeyDown(KeyCode.G)) StartCoroutine(CubeSpawn("G"));
        if (Input.GetKeyDown(KeyCode.H)) StartCoroutine(CubeSpawn("H"));
        if (Input.GetKeyDown(KeyCode.I)) StartCoroutine(CubeSpawn("I"));
        if (Input.GetKeyDown(KeyCode.J)) StartCoroutine(CubeSpawn("J"));
        if (Input.GetKeyDown(KeyCode.K)) StartCoroutine(CubeSpawn("K"));
        if (Input.GetKeyDown(KeyCode.L)) StartCoroutine(CubeSpawn("L"));
        if (Input.GetKeyDown(KeyCode.M)) StartCoroutine(CubeSpawn("M"));
        if (Input.GetKeyDown(KeyCode.N)) StartCoroutine(CubeSpawn("N"));
        if (Input.GetKeyDown(KeyCode.O)) StartCoroutine(CubeSpawn("O"));
        if (Input.GetKeyDown(KeyCode.P)) StartCoroutine(CubeSpawn("P"));
        if (Input.GetKeyDown(KeyCode.Q)) StartCoroutine(CubeSpawn("Q"));
        if (Input.GetKeyDown(KeyCode.R)) StartCoroutine(CubeSpawn("R"));
        if (Input.GetKeyDown(KeyCode.S)) StartCoroutine(CubeSpawn("S"));
        if (Input.GetKeyDown(KeyCode.T)) StartCoroutine(CubeSpawn("T"));
        if (Input.GetKeyDown(KeyCode.U)) StartCoroutine(CubeSpawn("U"));
        if (Input.GetKeyDown(KeyCode.V)) StartCoroutine(CubeSpawn("V"));
        if (Input.GetKeyDown(KeyCode.W)) StartCoroutine(CubeSpawn("W"));
        if (Input.GetKeyDown(KeyCode.X)) StartCoroutine(CubeSpawn("X"));
        if (Input.GetKeyDown(KeyCode.Y)) StartCoroutine(CubeSpawn("Y"));
        if (Input.GetKeyDown(KeyCode.Z)) StartCoroutine(CubeSpawn("Z"));





    }
    /// <summary>
    /// Spawning cube and changing the string color randomly
    /// </summary>
    /// <param name="alphabet"></param>
    IEnumerator CubeSpawn(string alphabet)
    {
        GameObject tempCube = Instantiate(cuberefab, spawnPos.position, Quaternion.identity, spawnPos) as GameObject;

        CharacterText characterGenerator = tempCube.GetComponent<CharacterText>();
        characterGenerator.charaterText.text = alphabet;
        characterGenerator.charaterText.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        Debug.Log("Text " + characterGenerator.charaterText.text);

        yield return new WaitForSeconds(destroyAfterSeconds);
        Destroy(tempCube);

    }
}
