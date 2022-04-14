using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luciole : MonoBehaviour
{
    [SerializeField] private Transform m_player;
    private Animator m_lucioleAnimator;

    private float m_distance;
    //[SerializeField] private float m_triggerDistance;

    // Start is called before the first frame update
    void Start()
    {
        m_lucioleAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        m_distance = Vector3.Distance(transform.position, m_player.position);
        m_lucioleAnimator.SetFloat("Distance", m_distance);
    }
}
