using UnityEngine;
using UnityEngine.UI;

public class HPBarPlacement : MonoBehaviour
{

    [SerializeField] private GameObject hpBarPrefab, hpBar;
    [SerializeField] private Image hpFill;
    [SerializeField] private float yOffset = 1.5f;
    [SerializeField] private float maxHP = 100f, currentHP, damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        hpBar = Instantiate(hpBarPrefab);
        hpBar.GetComponent<Canvas>().worldCamera = Camera.main;
        hpFill = hpBar.transform.GetChild(0).GetComponent<Image>();
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarPosition();
        UpdateHP();
        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void HealthBarPosition()
    {
        Vector3 barPos = transform.position + transform.up * yOffset;
        hpBar.transform.position = barPos;
    }

    private void TakeDamage(float damageAmount)
    {
        currentHP -= damageAmount;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
    }

    private void UpdateHP()
    {
        hpFill.fillAmount = currentHP / maxHP;
    }

    private void OnMouseDown()
    {
        TakeDamage(damage);
    }

}
