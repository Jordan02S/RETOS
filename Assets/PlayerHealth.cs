using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; 

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    
    public void TakeDamage(int amount)
    {
        if (amount > 0)
        {
            health -= amount;

            
            if (health < 0)
            {
                health = 0;
            }

            Debug.Log("Vida del jugador: " + health);

            
            if (health == 0)
            {
                DestroyPlayer();
            }
        }
        else
        {
            Debug.LogWarning("La cantidad de daño debe ser positiva.");
        }
    }

    
    private void DestroyPlayer()
    {
        Debug.Log("El jugador ha sido destruido.");
        Destroy(gameObject); 
    }
}
