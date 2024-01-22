using UnityEngine;

public class RotationEx : MonoBehaviour
{
    [SerializeField] private Transform Target;
    void Update()
    {
        // Sürekli döndürmek için kullanılıyor. İçerisine girilen değer kadar o düzlemde açısal olarak döndürüyor.
        transform.Rotate(0,.5f,0);
        
        // Belli bir açıya getirmek için kullanılıyor. Doğrudan yeni bir rotasyon ataması yapıyoruz.
        //transform.localEulerAngles = new Vector3(3, 0, 45);
        
        // Belli bir game objeye baktırmak için kullanılıyor.
        transform.LookAt(Target);
    }
}
