using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RutaEnemyPurplePatrullaje : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent _agent;

    public Transform[] esquinas;

    private Vector3 currentDestination;
    private int nextPoint = 0;

    public GameObject gameOverText;

    public float maxPosition = 6;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        if (esquinas.Length > 0)
        {
            currentDestination = esquinas[nextPoint].position;
            _agent.SetDestination(currentDestination);
            nextPoint++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, currentDestination) < 0.2f)
        {
            currentDestination = esquinas[nextPoint].position;
            _agent.SetDestination(currentDestination);
            nextPoint++;
            if (nextPoint > 6) nextPoint = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
