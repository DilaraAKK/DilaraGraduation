using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerScript : MonoBehaviour
{
    public ProgressBar bar;
    public NewLevelManager newlevelManager;
    public float value = 0;
    public CameraScript cameraScript;
    public Rigidbody myRig;
    public Animator anim;

    public Vector3 mousePosition;
    public float speed;

    public GameObject Canvas;
    public GameObject LongQuestion;
    public GameObject engelll;

    // public Button trueButton;
    public Vector3 turnPoint; //sınır diyebiliriz

    public GameObject Engeller;
    public GameObject FirstQuestion;
    public GameObject SecondQuestion;
    public GameObject ThirdQuestion;
    public GameObject Dort;
    public GameObject Bes;
    public GameObject Alti;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    public GameObject Ten;
    public GameObject Eleven;
    public GameObject Twelve;
    public GameObject Thirteen;
    public GameObject Fourteen;
    public GameObject Fifteen;
    public GameObject Cactus;
    public TypeWriter typeWriter;
    public Button trueButton;
    public Button falseButton;
    public Color greenColor;
    public Color redColor;
    public float backForce;
    private bool isHurt = false;
    public Button firstOption;
    public Button secondOption;
    private bool truebuttonClicked = false;

    public LevelManager levelManager;
    public float ButtonReactivateDelay = 1f;



    void Start()
    {
        myRig = GetComponent<Rigidbody>();
        //tra.rotation = Quaternion.Euler(0, 0, 0);
        anim = GetComponent<Animator>();
        engelll = GameObject.FindWithTag("engel");
        // trueButton.onClick.AddListener(TaskOnClick);
        cameraScript = GameObject.FindWithTag("MainCamera").GetComponent<CameraScript>();
        // falseButton.onClick.AddListener(TaskOnClick);
        // trueButton.onClick.AddListener(TaskOnClick);

    }

    private void Update()
    {

        if (LongQuestion.activeInHierarchy == false)
        {
            firstOption.interactable = true;
            // firstOption.onClick.RemoveListener(WhenOnClick);
            secondOption.interactable = true;
        }
        if (Canvas.activeInHierarchy == false)
        {
            trueButton.interactable = true;
            falseButton.interactable = true;
        }
        backForce = Mathf.Clamp(backForce + Time.deltaTime * 3.25f, -1, 1);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, turnPoint.x - 2.15f, turnPoint.x + 2.15f), transform.position.y, transform.position.z);
        float horizontal = 0;
        // transform.position =Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z), ref smoothInputVelocity, 0.1f);
        // transform.position = Vector3.SmoothDamp(transform.position, new Vector3(Mathf.Clamp(transform.position.x, turnPoint.x - 2.15f, turnPoint.x + 2.15f), transform.position.y, transform.position.z), ref smoothInputVelocity, 0.1f);

        if (Input.GetMouseButtonDown(0) && Canvas.activeInHierarchy == false && LongQuestion.activeInHierarchy == false)
        {
            mousePosition = Input.mousePosition;
            // myRig.velocity = new Vector3(Input.GetAxis("Horizontal") * 5, myRig.velocity.y, Input.GetAxis("Vertical") * 5);
            ;

        }
        else
        {
            anim.SetBool("isWalking", false);
        }


        if (Input.GetMouseButton(0) && Canvas.activeInHierarchy == false && LongQuestion.activeInHierarchy == false)
        {
            horizontal = (Input.mousePosition.x - mousePosition.x) / Screen.width * 1.5f;
            mousePosition = Input.mousePosition;

            transform.position += transform.forward * Time.deltaTime * speed + transform.right * horizontal * 5;

            anim.SetBool("isWalking", true);


        }
        else
        {
            anim.SetBool("isWalking", false);
        }



        // if (FirstQuestion.activeInHierarchy == false && SecondQuestion.activeInHierarchy == true)  //sorular değişebiliyor bi de sorulara göre doğru yanlış ayarla.
        // {
        //     // thisText.text = "yeni soru";
        //     falseButton.onClick.AddListener(TaskOnClick);
        //     trueButton.onClick.RemoveListener(TaskOnClick);
        //     ColorBlock tb = falseButton.colors;
        //     tb.selectedColor = greenColor;
        //     falseButton.colors = tb;

        //     ColorBlock fb = trueButton.colors;
        //     fb.selectedColor = redColor;
        //     trueButton.colors = fb;

        // }
        // if (SecondQuestion.activeInHierarchy == false && FirstQuestion.activeInHierarchy == false)


        // {
        //     // thisText.text = "ikinci soru başlayabilr";
        //     falseButton.onClick.RemoveListener(TaskOnClick);    //artık bu şekilde çalışıyor
        //     trueButton.onClick.AddListener(TaskOnClick);


        //     // falseButton.onClick.AddListener(FalseClose);
        //     ColorBlock tb = trueButton.colors;
        //     tb.selectedColor = greenColor;
        //     trueButton.colors = tb;

        //     ColorBlock fb = falseButton.colors;
        //     fb.selectedColor = redColor;
        //     falseButton.colors = fb;


        // }
        // if (ThirdQuestion.activeInHierarchy == false && SecondQuestion.activeInHierarchy == false && FirstQuestion.activeInHierarchy == false)
        // {
        //     trueButton.onClick.RemoveListener(TaskOnClick);  //cevabı false
        //     falseButton.onClick.AddListener(TaskOnClick);


        //     ColorBlock tb = falseButton.colors;
        //     tb.selectedColor = greenColor;
        //     falseButton.colors = tb;

        //     ColorBlock fb = trueButton.colors;
        //     fb.selectedColor = redColor;
        //     trueButton.colors = fb;
        // }







        //   if(Input.GetMouseButtonDown(0))
        //     {
        //         anim.SetBool("isWalking", true);
        //     }
        //     if(Input.GetMouseButtonUp(0))
        //     {
        //         anim.SetBool("isWalking", false);
        //     }



    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("engel"))
        {
            myRig.velocity = new Vector3(0, 0, 0);
            anim.StopPlayback();
            Debug.Log("engell");
            // gameObject.GetComponent<Animator>().enabled = false;
            // myRig.constraints = RigidbodyConstraints.FreezePosition;
            // myRig.constraints = RigidbodyConstraints.FreezeRotation;

            //     Canvas.SetActive(true);
            //     foreach (Canvas i in Canvas.GetComponentsInChildren<Canvas>())
            //     {
            //         typeWriter.enabled = true;
            //     }


            // cameraScript.engeldeCagır();


            // Destroy(engelll);
            if (collision.gameObject.transform.parent.gameObject.name == "FirstQuestion")
            {
                Long();
                FirstQuestion.SetActive(false);
                IkinciDogruL();
                value += 33.3333333333f;
                bar.BarValue = value;
                Debug.Log("neyseee");

            }
            if (collision.gameObject.transform.parent.gameObject.name == "Second")
            {
                Long();
                SecondQuestion.SetActive(false);
                IlkiDogruL();
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Third")
            {
                Short();
                ThirdQuestion.SetActive(false);
                IlkiDogruS();
                value += 33.3333333333f;
                bar.BarValue = value;

            }
            //LONG UZUN SORULAR BURAYA GİRİYOR


            if (collision.gameObject.transform.parent.gameObject.name == "Dort")
            {
                Long();
                IlkiDogruL();
                Dort.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Bes")
            {
                Debug.Log("BEŞE DOKUNDU");
                Long();
                IkinciDogruL();             //ikinci dogru
                Bes.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Alti")
            {
                Debug.Log("ALTIYA DOKUNDU");
                Short();
                IkinciDogruS();
                Alti.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Seven")
            {
                Long();
                IlkiDogruL();
                Seven.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Eight")
            {
                Short();
                IlkiDogruS();
                Eight.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Nine")
            {
                Long();
                IkinciDogruL();
                Nine.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Ten")
            {
                Long();
                IlkiDogruL();
                Ten.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Eleven")
            {
                Long();
                IlkiDogruL();
                Eleven.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Twelve")
            {
                Long();
                IlkiDogruL();
                Twelve.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Thirteen")
            {
                Long();
                IkinciDogruL();
                Thirteen.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
                Debug.Log("13 GİROY MU");
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Fourteen")
            {
                Long();
                IlkiDogruL();
                Fourteen.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }
            if (collision.gameObject.transform.parent.gameObject.name == "Fifteen")
            {
                Long();
                IkinciDogruL();
                Fifteen.SetActive(false);
                value += 33.3333333333f;
                bar.BarValue = value;
            }

        }

        // Engeller.SetActive(false);


        // if ((collision.gameObject.CompareTag("engel") && Input.GetMouseButtonDown(0)) && (collision.gameObject.CompareTag("engel") && Input.GetMouseButton(0)))
        // {

        //     gameObject.GetComponent<Animator>().enabled = false;
        //     myRig.velocity = new Vector3(0, 0, 0);
        //     myRig.constraints = RigidbodyConstraints.FreezePosition;
        //     myRig.constraints = RigidbodyConstraints.FreezeRotation;


        //     Debug.Log("çalıstt");
        // }

        if (collision.gameObject == Cactus)
        {
            // backForce = 50;   //üzerinde oyna, çok da geriye atmıyo çünkü
            myRig.velocity = new Vector3(0, 0, 0);
            myRig.constraints = RigidbodyConstraints.FreezePosition;
            myRig.constraints = RigidbodyConstraints.FreezeRotation;


            // myRig.AddForce(new Vector3(0, 0, backForce), ForceMode.Impulse);
            // // myRig.AddForce(Vector3.back * backForce);

            anim.StopPlayback();
            // isHurt = true;
            // hurt();
            myRig.AddForce(-transform.forward * 7, ForceMode.Impulse);
            // Debug.Log("backforcee");
        }
        // if (collision.gameObject.tag == "Finish" && typeWriter.Level4.activeInHierarchy == false )
        // {
        //     Debug.Log("finish");
        //     newlevelManager.win();
        // }
        // else if(collision.gameObject.tag == "Finish" &&  typeWriter.Level4.activeInHierarchy == true)
        // {
        //     newlevelManager.final();  //burda direkt final sahnesine geçiyor istersen bikaç saniye bekletip veya finish tuşu yapıp ona basınca geçmesini sağla.
        // }

        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("finish");
            newlevelManager.win();
        }



    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Canvas.SetActive(false);
        LongQuestion.SetActive(false);
        // LongQuestion.SetActive(false); // Bİ BAK
        //buraya bi sevinme veya dönme animasyonu koy.
        //   anim.SetBool("isJump", true);
        anim.Play("Jump");
        // value += 5;
        // bar.BarValue = value;

    }


    public void hurt()
    {
        if (isHurt)
        {
            isHurt = true;
            backForce = -1;
        }
    }
    public void Short()
    {
        foreach (Canvas i in Canvas.GetComponentsInChildren<Canvas>())
        {
            typeWriter.enabled = true;
        }
        myRig.velocity = new Vector3(0, 0, 0);
        anim.StopPlayback();
        Debug.Log("engell");
        Canvas.SetActive(true);
    }
    public void Long()
    {
        foreach (Canvas i in LongQuestion.GetComponentsInChildren<Canvas>())
        {
            typeWriter.enabled = true;
            Debug.Log("nie");
        }
        myRig.velocity = new Vector3(0, 0, 0);
        anim.StopPlayback();
        Debug.Log("longgg");
        LongQuestion.SetActive(true);


    }
    public void IlkiDogruS()
    {
        falseButton.onClick.RemoveListener(TaskOnClick);    //artık bu şekilde çalışıyor
        trueButton.onClick.AddListener(TaskOnClick);
        falseButton.onClick.AddListener(FalseOnClick);
        trueButton.onClick.RemoveListener(FalseOnClick);

        falseButton.onClick.RemoveListener(falseOnClick);


        // falseButton.onClick.AddListener(FalseClose);
        ColorBlock tb = trueButton.colors;
        tb.selectedColor = greenColor;
        trueButton.colors = tb;

        ColorBlock fb = falseButton.colors;
        fb.selectedColor = redColor;
        falseButton.colors = fb;
    }
    public void IkinciDogruS()
    {
        falseButton.onClick.AddListener(TaskOnClick);
        trueButton.onClick.RemoveListener(TaskOnClick);
        trueButton.onClick.AddListener(FalseOnClick);
        falseButton.onClick.RemoveListener(FalseOnClick);

        trueButton.onClick.AddListener(trueOnClick);



        ColorBlock tb = falseButton.colors;
        tb.selectedColor = greenColor;
        falseButton.colors = tb;

        ColorBlock fb = trueButton.colors;
        fb.selectedColor = redColor;
        trueButton.colors = fb;
    }
    public void IlkiDogruL()
    {
        secondOption.onClick.RemoveListener(TaskOnClick);    //artık bu şekilde çalışıyor
        firstOption.onClick.AddListener(TaskOnClick);
        secondOption.onClick.AddListener(FalseOnClick);
        firstOption.onClick.RemoveListener(FalseOnClick);

        // firstOption.onClick.RemoveListener(WhenOnClick);
        secondOption.onClick.RemoveListener(secondOnClick);


        // falseButton.onClick.AddListener(FalseClose);
        ColorBlock tb = trueButton.colors;
        tb.selectedColor = greenColor;
        firstOption.colors = tb;

        ColorBlock fb = falseButton.colors;
        fb.selectedColor = redColor;
        secondOption.colors = fb;
    }
    public void IkinciDogruL()
    {
        secondOption.onClick.AddListener(TaskOnClick);
        firstOption.onClick.RemoveListener(TaskOnClick);
        firstOption.onClick.AddListener(FalseOnClick);
        secondOption.onClick.RemoveListener(FalseOnClick);

        firstOption.onClick.AddListener(WhenOnClick);






        ColorBlock tb = falseButton.colors;
        tb.selectedColor = greenColor;
        secondOption.colors = tb;

        ColorBlock fb = trueButton.colors;
        fb.selectedColor = redColor;
        firstOption.colors = fb;
    }



    private void FalseOnClick()
    {
        newlevelManager.addScore();
        Debug.Log("events calıstıı");
    }
    public void WhenOnClick()   //buradan itibaren butonları kapatacağız
    {
        if (firstOption.onClick.GetPersistentEventCount() == 1)
        {
            StartCoroutine(Wait());
        }
    }
    public void secondOnClick()
    {
        if (secondOption.onClick.GetPersistentEventCount() == 1)
        {
            StartCoroutine(WaitSecond());
        }
    }
    public void trueOnClick()
    {
        if (trueButton.onClick.GetPersistentEventCount() == 1)
        {
            StartCoroutine(WaitTrue());
        }
    }
    public void falseOnClick()
    {
        if (falseButton.onClick.GetPersistentEventCount() == 1)
        {
            StartCoroutine(WaitFalse());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        firstOption.interactable = false;
    }
    IEnumerator WaitSecond()
    {
        yield return new WaitForSeconds(0.3f);
        secondOption.interactable = false;
    }
    IEnumerator WaitTrue()
    {
        yield return new WaitForSeconds(0.3f);
        trueButton.interactable = false;
    }
    IEnumerator WaitFalse()
    {
        yield return new WaitForSeconds(0.3f);
        falseButton.interactable = false;
    }



}






