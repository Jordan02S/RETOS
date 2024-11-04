using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0; 

    private void Start()
    {
        
        InvokeRepeating("IncreaseScoreOverTime", 1f, 1f);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddScore(10); 
        }

        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SubtractScore(5); 
        }
    }

    private void IncreaseScoreOverTime()
    {
        score += 1;
        Debug.Log("Score (incremento automático): " + score);
    }

    
    public void AddScore(int amount)
    {
        if (amount > 0)
        {
            score += amount;
            Debug.Log("Score (+): " + score);
        }
        else
        {
            Debug.LogWarning("La cantidad para agregar debe ser positiva.");
        }
    }

    
    public void SubtractScore(int amount)
    {
        if (amount > 0)
        {
            if (score >= amount)
            {
                score -= amount;
                Debug.Log("Score (-): " + score);
            }
            else
            {
                Debug.LogWarning("No se puede disminuir el score por debajo de 0.");
            }
        }
        else
        {
            Debug.LogWarning("La cantidad para restar debe ser positiva.");
        }
    }
}
