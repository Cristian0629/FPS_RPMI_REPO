using UnityEngine;
using UnityEngine.AI; //Libreria de componentes NavMesh

public class EnemyAIBase : MonoBehaviour
{
    #region General Variables
    [Header("AI Configuration")]
    [SerializeField] NavMeshAgent agent; //Ref al cerebro del agente
    [SerializeField] Transform target; //Ref al target a perseguir (Variable)
    [SerializeField] LayerMask targetLayer; //Define layer del target (Detecciones)
    [SerializeField] LayerMask groundLayer; //Define layer del suelo (Evita ir a zonas sin suelo)

    [Header("Patroling Stats")]
    [SerializeField] float walkPointRange = 10f; //Radio máximo para determinar puntos a perseguir
    Vector3 walkPoint; //Posición del punto random a perseguir
    bool walkPointSet; //Hay punto a perseguir generado? Si es false, genera uno

    [Header("Attacking Stats")]
    [SerializeField] float timeBetweenAttacks = 1f; //Cooldown entre ataques
    [SerializeField] GameObject projectile; //Ref a la bala física que dispara el enemigo
    [SerializeField] Transform shootPoint; //Posición desde la que dispara la bala
    [SerializeField] float shootSpeedY; //Fuerza de disparo hacia arriba (Catapulta)
    [SerializeField] float shootSpeedZ = 10f; //Fuerza de disparp hacia adelante (Siempre está)
    bool alreadyAttacked; //Si es verdadero no stackea ataques y entra en esperaa entre ataques

    [Header("States & Detection")]
    [SerializeField] float sightRange = 8f; //Radio del detector de persecución
    [SerializeField] float attackRange = 2f; //Radio del detector de ataque
    [SerializeField] bool targetInSightRange; //Determina si es verdadero que podemos perseguir al target
    [SerializeField] bool targetInAttackRange; //Determina si es verdadero que podemos atacar al target

    [Header("Stuck Detection")]
    [SerializeField] float stuckCheckTime = 2f; //Tiempo que el agente espera estando quieto antes de darse cuenta de que está stuck
    [SerializeField] float stuckThreshold = 0.1f; //Margen de detección de stuck
    [SerializeField] float maxStuckDuration = 3f; //Tiempo máximo de estar stuck

    float stuckTimer; //Reloj que cuanta el tiempo de estar stuck
    float lastCheckTime; //Tiempo de checkeo previo de stuck
    Vector3 lastPosition; //Posición del último walkpoint perseguido
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
