using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;
    [SerializeField] float spawnRate = 1f, minHeight = -1f, maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(pipesPrefab, transform.position, Quaternion.identity, this.transform);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}