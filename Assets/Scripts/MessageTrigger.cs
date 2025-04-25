using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageTrigger : MonoBehaviour
{
    public string message;
    public TextMeshProUGUI messageText;
    public float displayTime = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllCoroutines();
            StartCoroutine(ShowMessage());
        }
    }

    private System.Collections.IEnumerator ShowMessage()
    {
        messageText.text = message;
        messageText.gameObject.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        messageText.gameObject.SetActive(false);
    }
}

