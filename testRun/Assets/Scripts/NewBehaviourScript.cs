using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public Rigidbody parrot;
    public Joystick joystick;
    //public Animation walk;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")||joystick.Vertical>0.3)
        {
            //ismoving = true;
            //transform.position = transform.position - (Time.deltaTime*transform.forward*10);
            //Vector3 direc = parrot.forward*6;
            parrot.AddRelativeForce(0, 0, -300*Time.deltaTime, ForceMode.Impulse);
            anim.Play("Armature|move");
            anim.SetBool("ismoving", true);
        }
        else if (Input.GetKey("s")||joystick.Vertical<(-0.3))
        {
            //ismoving = true;
            transform.position = transform.position + (Time.deltaTime*transform.forward*10);
            anim.Play("Armature|move");
            anim.SetBool("ismoving", true);
        }
        else
            anim.SetBool("ismoving", false);
        //ismoving = false;
        if (Input.GetKey("a") || joystick.Horizontal < (-0.5))
        {
            parrot.transform.Rotate(0, ( joystick.Horizontal), 0, Space.Self);
        }
        else if (Input.GetKey("d") || joystick.Horizontal>0.5)
        {
            parrot.transform.Rotate(0, (joystick.Horizontal), 0, Space.Self);
        }
    }
    public void Jump()
    {

            anim.Play("Armature|move");
            parrot.AddForce(0, 30, 0, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {

    }
}
