using UnityEngine;
using UnityEngine.UI;

public class BulletCount : MonoBehaviour
{
    private Text _text;

    public void AmmoChange(int ammo)
    {
        _text.text = ammo.ToString();
    }

    private void Start()
    {
        _text = GetComponent<Text>();
    }
}
