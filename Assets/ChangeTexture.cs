using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    // MESSI
    public List<Texture> armColor = new List<Texture>();
    public List<Texture> faceColor = new List<Texture>();
    public List<Texture> kneeColor = new List<Texture>();

    public Material originalArmSkin;
    public Material originalFaceSkin;
    public Material originalKneeSkin;

    // RONALDO
    public List<Texture> suitColor = new List<Texture>();

    public Material originalSuitColor;

    private bool isScaleDown = false;
    private bool isScaleUp = false;

    private bool isRotating = false;
    public GameObject messi;

    public GameObject changeColor;
    public GameObject customizeButton;
    public GameObject transformButton;
    public GameObject animateButton;
    public GameObject changeModel;
    public GameObject back;
    public GameObject transformList;
    public GameObject messiAnimationList;
    public GameObject ronaldoAnimationList;
    public GameObject rotate;
    public GameObject scaleDown;
    public GameObject scaleUp;

    public GameObject menu;


    //Animators
    public Animator messiAnim;
    public Animator crAnim;

    // Messi Animations
    public bool slideTackle = false;
    public bool pass = false;
    public bool penaltyKick = false;
    public bool header = false;

    // Ronaldo Animations
    public bool flop = false;
    public bool foul = false;
    public bool spin = false;
    public bool bicycleKick = false;



    // Change Model
    public bool isMessi = true;
    public GameObject leoMessi;
    public GameObject ronaldo;
    // Start is called before the first frame update

    public void Start()
    {
        originalArmSkin.mainTexture = armColor[0];
        originalFaceSkin.mainTexture = faceColor[0];
        originalKneeSkin.mainTexture = kneeColor[0];

        originalSuitColor.mainTexture = suitColor[0];

        changeColor.SetActive(false);
        back.SetActive(false);

    }


    // Update is called once per frame

    public void Update()
    {
        Rotate();
        ScaleUp();
        ScaleDown();

        // Messi ANIMATIONS
        SlideTackle();
        Pass();
        PenaltyKick();
        Header();

        // CR7 ANIMATIONS
        Flop();
        Foul();
        InvertedKick();
        Spin();



       
    }

    public void Customize()
    {
        changeColor.SetActive(true);
        menu.SetActive(false);
        back.SetActive(true);

    }

    public void Back()
    {
        menu.SetActive(true);
        back.SetActive(false);
        changeColor.SetActive(false);
        transformList.SetActive(false);
        messiAnimationList.SetActive(false);
        ronaldoAnimationList.SetActive(false);
    }

    public void TransformButton()
    {
        transformList.SetActive(true);
        menu.SetActive(false);
    }

    public void ChangeModel()
    {
        isMessi = !isMessi;

        if (isMessi == true)
        {
            leoMessi.SetActive(true);
            ronaldo.SetActive(false);
        }
        else
        {
            ronaldo.SetActive(true);
            leoMessi.SetActive(false);
        }
    }

    public void Animate()
    {
        menu.SetActive(false);

        if (isMessi == true)
        {
            messiAnimationList.SetActive(true);
        }
        else
        {
            ronaldoAnimationList.SetActive(true);
        }
        
    }

    public void InvertedKick()
    {
        if (bicycleKick == true)
        {
            crAnim.SetBool("Bicycle Kick", true);
        }
        else
        {
            crAnim.SetBool("Bicycle Kick", false);
        }
    }

    public void InvertedKickDown()
    {
        bicycleKick = true;
    }

    public void InvertedKickUp()
    {
        bicycleKick = false;
    }

    public void Spin()
    {
        if (spin == true)
        {
            crAnim.SetBool("Spin", spin);
        }
        else
        {
            crAnim.SetBool("Spin", spin);
        }
    }

    public void SpinDown()
    {
        spin = true;
    }

    public void SpinUp()
    {
        spin = false;
    }

    public void Foul()
    {
        if (foul == true)
        {
            crAnim.SetBool("THRILLER", true);
        }
        else
        {
            crAnim.SetBool("THRILLER", false);
        }
    }

    public void FoulDown()
    {
        foul = true;
    }

    public void FoulUp()
    {
        foul = false;
    }

    public void Flop()
    {
        if (flop == true)
        {
            crAnim.SetBool("YMCA", true);
        }
        else
        {
            crAnim.SetBool("YMCA", false);
        }
    }

    public void FlopDown()
    {
        flop = true;
    }

    public void FlopUp()
    {
        flop = false;
    }

    public void Header()
    {
        if (header == true)
        {
            messiAnim.SetBool("Header", header);
        }
        else
        {
            messiAnim.SetBool("Header", header);
        }
    }

    public void HeaderDown()
    {
        header = true;
    }

    public void HeaderUp()
    {
        header = false;
    }

    public void PenaltyKick()
    {
        if (penaltyKick == true)
        {
            messiAnim.SetBool("Penalty", true);
        }
        else
        {
            messiAnim.SetBool("Penalty", false);
        }
    }

    public void PenaltyKickDown()
    {
        penaltyKick = true;
    }

    public void PenaltyKickUp()
    {
        penaltyKick = false;
    }

    public void Pass()
    {
        if (pass == true)
        {
            messiAnim.SetBool("THRILLER", pass);
        }
        else
        {
            messiAnim.SetBool("THRILLER", false);
        }
    }

    public void PassDown()
    {
        pass = true;
    }

    public void PassUp()
    {
        pass = false;
    }
    public void SlideTackle()
    {
        if (slideTackle == true)
        {
            messiAnim.SetBool("YMCA", slideTackle);
        }

        else
        {
            messiAnim.SetBool("YMCA", false);
        }
    }

    public void SlideTackleDown()
    {
        slideTackle = true;
    }
     public void SlideTackleUp()
    {
        slideTackle = false;
    }

    public void Rotate()
    {

        if (isRotating == true)
        {
            messi.transform.Rotate(0, 2f, 0);
        }
       
        
    }



    public void RotateOnPointerDown()
    {
        // Called when the button is pressed
        isRotating = true;
    }

    public void RotateOnPointerUp()
    {
        // Called when the button is released
        isRotating = false;
    }

    public void ScaleUp()
    {
        float scaleFactor = 1.0f + (2f * Time.deltaTime);
        if (isScaleUp == true)
        {
            messi.transform.localScale *= scaleFactor;
        }
    }
   


    public void ScaleUpOnPointerDown()
    {
        isScaleUp = true;
    }
     public void ScaleUpOnPointerUp()
    {
        isScaleUp = false;
    }

    public void ScaleDown()
    {
        float scaleFactor = 1.0f - (2f * Time.deltaTime);
        if (isScaleDown == true)
        {
            messi.transform.localScale *= scaleFactor;
        }
    }

    public void ScaleDownOnPointerDown()
    {
        isScaleDown = true;
    }
    public void ScaleDownOnPointerUp()
    {
        isScaleDown = false;
    }



    public void ChangeColor()
    {
        if (isMessi == true)
        {
            int currentTextureIndex = armColor.IndexOf(originalArmSkin.mainTexture);
            currentTextureIndex++;

            if (currentTextureIndex >= armColor.Count)
            {
                currentTextureIndex = 0;
            }

            originalArmSkin.mainTexture = armColor[currentTextureIndex];

            int currentFaceTextureIndex = faceColor.IndexOf(originalFaceSkin.mainTexture);
            currentFaceTextureIndex++;

            if (currentFaceTextureIndex >= faceColor.Count)
            {
                currentFaceTextureIndex = 0;
            }

            originalFaceSkin.mainTexture = faceColor[currentFaceTextureIndex];

            int currentKneeTextureIndex = kneeColor.IndexOf(originalKneeSkin.mainTexture);
            currentKneeTextureIndex++;

            if (currentKneeTextureIndex >= kneeColor.Count)
            {
                currentKneeTextureIndex = 0;
            }

            originalKneeSkin.mainTexture = kneeColor[currentKneeTextureIndex];
        }

        else
        {
            int currentSuitTextureIndex = suitColor.IndexOf(originalSuitColor.mainTexture);
            currentSuitTextureIndex++;

            if (currentSuitTextureIndex >= suitColor.Count)
            {
                currentSuitTextureIndex = 0;
            }

            originalSuitColor.mainTexture = suitColor[currentSuitTextureIndex];

        }





    }

  
}
