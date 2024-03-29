using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuongtac2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Animator myAnimator;
    public GameObject preab_obj;
    public string prefab_tag_name;

    private bool chayPhai;
    private bool chayTrai;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.position = transform.position + movement;

        float speed = movement.magnitude;
        myAnimator.SetFloat("speed", speed);

        chayPhai = Input.GetKey(KeyCode.D);
        chayTrai = Input.GetKey(KeyCode.A);


        myAnimator.SetBool("dk_chayphai", chayPhai);
        myAnimator.SetBool("dk_chaytrai", chayTrai);


        if (!chayPhai && !chayTrai )
        {
            myAnimator.SetBool("dk_chayphai", false);
            myAnimator.SetBool("dk_chaytrai", false);
        }


    }
}