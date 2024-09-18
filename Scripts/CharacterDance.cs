using UnityEngine;

public class CharacterDance : MonoBehaviour
{
    private Animator animator;  // Componente Animator

    void Start()
    {
        // Obtener el componente Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Si se presiona la tecla "B" para bailar
        if (Input.GetKeyDown(KeyCode.B))
        {
            Dance();
        }
    }

    void Dance()
    {
        // Activar la animación de baile
        animator.SetTrigger("isDancing");
    }
}
