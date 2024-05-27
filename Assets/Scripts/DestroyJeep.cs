using UnityEngine;
using UnityEngine.SceneManagement;

public class Jeep : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, столкнулся ли джип с объектом с тегом "Barier"
        if (collision.gameObject.CompareTag("Barier"))
            EndGame();
    }
    public void EndGame()
    {
        // пауза для того, чтобы увидеть рекорд, к сожалению получилась только таким способом
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
    }
}
