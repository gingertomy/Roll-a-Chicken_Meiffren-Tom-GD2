using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WolfTrap : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreDatas;
    [SerializeField] private GameObject _life1;
    [SerializeField] private GameObject _life2;
    [SerializeField] private GameObject _life3;
    [SerializeField] private Timer _timer;
    [SerializeField] private AudioClip _trapSound;
    private bool _used = false;
    private void Start()
    {
        UpdateLives();
        _scoreDatas.Life = 3;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Collector>() != null)
        {
            if (!_used)
            {
                if (_scoreDatas.Life > 0)
                {
                    _scoreDatas.Life--;
                    UpdateLives();
                    AudioSource.PlayClipAtPoint(_trapSound, transform.position);
                    Destroy(gameObject);
                }

                if (_scoreDatas.Life == 0)
                {
                    _timer.LoseTimer();
                    AudioSource.PlayClipAtPoint(_trapSound, transform.position);
                    Destroy(gameObject);
                }
            }
        }
    }

    private void UpdateLives()
    {
        _life1.SetActive(_scoreDatas.Life >= 1);
        _life2.SetActive(_scoreDatas.Life >= 2);
        _life3.SetActive(_scoreDatas.Life >= 3);
    }
}
