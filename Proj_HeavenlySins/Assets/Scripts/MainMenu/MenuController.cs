using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MenuController : MonoBehaviour {

    [SerializeField] private AudioClip _buttonPress;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void BeginSceneChange(string sceneName)
    {
        StartCoroutine(ChangeScene(sceneName));
    }

    private IEnumerator ChangeScene(string sceneName)
    {
        PlayAudio(_buttonPress);

        while(_audioSource.isPlaying)
            yield return null;

        SceneManager.LoadScene(sceneName);

        yield return null;
    }

    private void PlayAudio(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }

    public void Quit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit;
        #endif
    }
}
