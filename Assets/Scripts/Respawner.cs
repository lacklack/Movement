using UnityEngine;

public class Respawner : MonoBehaviour {
    [SerializeField] GameObject player;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnValue;

    public Respawner(GameObject player, Transform spawnPoint, float spawnValue) {
        this.player = player;
        this.spawnPoint = spawnPoint;
        this.spawnValue = spawnValue;
    }

    public GameObject Player => player;
    public Transform SpawnPoint => spawnPoint;
    public float SpawnValue => spawnValue;

    void Update() {
        if (player.transform.position.y < spawnValue) {
            RespawnPoint();
        }
    }

    void RespawnPoint() {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawnPoint.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
    }
}