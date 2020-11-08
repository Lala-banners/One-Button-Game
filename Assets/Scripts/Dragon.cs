using UnityEngine;
using UnityEngine.UI;


public class Dragon : MonoBehaviour
{
   
        [Tooltip("Where the fireball will shoot from.")]
        public Transform firePoint;

        [Tooltip("The fireball prefab.")]
        public GameObject fireball;

        [Tooltip("How fast the fireball shoots.")]
        public float fireRate = 2f;

    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public Slider healthBar;
    public Image fill;
    public Gradient gradient;



    private SpriteRenderer spriteRenderer;
   

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D playerCollider)
    {
        if (playerCollider.gameObject.tag == "Enemy") //if collided with an enemy
        {
            TakeDamage(20f); //Dragon take damage
            //Debug.Log("collision!");
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth = currentHealth - damage;
        healthBar.value = currentHealth;
        fill.color = gradient.Evaluate(healthBar.normalizedValue);
    }



    /// <summary>
    /// Flip the Sprite every time it's called
    /// </summary>
    public void Flip()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }

    public void ShootFireball() //Function to set the mouse as the one button
    {
        //If mouse click then shoot fireball where the mouse is pointing
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Camera mainCamera = Camera.main;
            Vector2 mousePos = Input.mousePosition;
            // Get Rotation for Z Rotation
            Vector2 worldMousePos = mainCamera.ScreenToWorldPoint(mousePos);
            Vector2 firePointPos = firePoint.transform.position;
            // Direction = Target - Current
            Vector2 direction = worldMousePos - firePointPos;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
            Instantiate<GameObject>(fireball, firePointPos, rotation);

            spriteRenderer.flipX = direction.x < 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ShootFireball();
    }
}
