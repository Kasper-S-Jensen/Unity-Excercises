using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public GameObject mole;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(SpawnMole), 1f, 2f);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void SpawnMole()
    {
        var randomX = Random.Range(-9f, 9f);
        var randomZ = Random.Range(-5f, 5);
        var moleGO = Instantiate(mole);
        moleGO.transform.position = new Vector3(randomX, 0f, randomZ);
    }
}