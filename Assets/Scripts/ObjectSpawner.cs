using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Массив префабов объектов для спавна
    public float minSpawnInterval = 1f; // Минимальный интервал спавна в секундах
    public float maxSpawnInterval = 10f; // Максимальный интервал спавна в секундах

    private float timer; // Таймер для отслеживания времени до следующего спавна
    private float spawnInterval; // Интервал спавна для текущего объекта

    void Start()
    {
        // Начальное значение интервала спавна
        SetRandomSpawnInterval();
    }

    void Update()
    {
        // Увеличиваем таймер
        timer += Time.deltaTime;

        // Если прошло достаточно времени, чтобы создать новый объект
        if (timer >= spawnInterval)
        {
            // Создаем новый объект
            SpawnObject();

            // Устанавливаем новый случайный интервал спавна
            SetRandomSpawnInterval();

            // Сбрасываем таймер
            timer = 0f;
        }
    }

    void SetRandomSpawnInterval()
    {
        // Генерируем случайный интервал спавна между минимальным и максимальным значениями
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void SpawnObject()
    {
        // Выбираем случайный префаб из массива
        GameObject selectedPrefab = objectPrefabs[Random.Range(0, objectPrefabs.Length)];

        // Создаем новый объект из выбранного префаба в текущей позиции спавна
        Instantiate(selectedPrefab, transform.position, Quaternion.identity);
    }
}
