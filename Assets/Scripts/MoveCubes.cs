using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 25f; // Скорость движения объектов по оси Z
    public float jeepSpeed = 10f; // Скорость движения джипа по оси X
    public float maxXPosition = 10f; // Максимальная позиция по оси X, куда может двигаться джип
    public float minXPosition = -10f; // Минимальная позиция по оси X, куда может двигаться джип
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Движение объектов по оси Z
        MoveCubes();

        // Движение джипа по оси X при нажатии клавиш влево или вправо
        MoveJeep();

        // Удаляем объекты, которые вышли за пределы области камеры
        MoveBarriers();

        MoveGrass();
    }

    void MoveCubes()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject cube in cubes)
        {
            cube.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    void MoveGrass()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Grass");

        foreach (GameObject cube in cubes)
        {
            cube.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void MoveBarriers()
    {
        GameObject[] barriers = GameObject.FindGameObjectsWithTag("Barier");

        foreach (GameObject cube in barriers)
        {
            cube.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void MoveJeep()
    {
        float moveInput = Input.GetAxisRaw("Horizontal"); // Получаем ввод по горизонтали (-1 для влево, 1 для вправо)

        // Инвертируем знак для корректного направления движения
        moveInput *= -1f;

        Vector3 moveDirection = new Vector3(moveInput, 0f, 0f); // Задаем направление движения джипа

        Vector3 newPosition = transform.position + moveDirection * jeepSpeed * Time.deltaTime; // Рассчитываем новую позицию

        // Применяем ограничения по оси X
        newPosition.x = Mathf.Clamp(newPosition.x, minXPosition, maxXPosition);

        transform.position = newPosition; // Двигаем джип
    }
}
