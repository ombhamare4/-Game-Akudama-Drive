using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Delivery : MonoBehaviour
{
    Color32 hasPackageColor = new Color32(15, 255, 0, 255);
    Color32 noPackageColor = new Color32(0, 255, 255, 255);
    [SerializeField] 
    float destroyDelay = 0.5f;
    [SerializeField]
    int PackageCount = 0;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ouch!");
        if (other.tag == "PackagePick" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "PackageDeliver" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            PackageCount += 1;
        }
    }
    void Update() 
    {
        if (PackageCount==20)
        {
            SceneManager.LoadScene(2);
        }
    }

}
