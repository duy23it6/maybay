using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    [Header("Bullet")]
    public GameObject bulletPrefab;

    [Header("Fire Point")]
    public Transform firePoint;

    [Header("Shooting Settings")]
    public float shootingInterval = 0.2f;

    private float lastBulletTime;

    void Update()
    {
        // Giữ chuột trái để bắn liên tục
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime >= shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        // Tạo đạn tại FirePoint
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
