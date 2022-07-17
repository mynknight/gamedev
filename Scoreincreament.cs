using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreincreament : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.scorebird++;
    }
}
