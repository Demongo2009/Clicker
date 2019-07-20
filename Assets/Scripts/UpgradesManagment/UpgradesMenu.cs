
using System.Dynamic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image; 

public class UpgradesMenu : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Animator animator;

    private IInputWrapper inputWrapper = new InputWrapperDragLeftRight();
    
    
        // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void CheckIfWindowIsDraggedOrTapped()
    {
        if (inputWrapper.IsTouchBegin())
        {
            EnableDrag();
        }

        if (inputWrapper.IsTouchMoved())
        {
            Drag();
        }

        if (inputWrapper.IsTouchEnd())
        {
            if (animator != null)
            {
                bool isOpened = animator.GetBool("isOpened");
                
                animator.SetBool("isOpened", !isOpened);
            }
            
        }
    }

    private void EnableDrag()
    {
        
    }

    private void Drag()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {

        animator.speed = 0;
        if (animator != null)
        {
            bool isOpened = animator.GetBool("isOpened");
                
            animator.SetBool("isOpened", !isOpened);
        }

        Animation anim = animator.GetCurrentAnimatorClipInfo(0);
        anim["OpenUpgrades"].time = Input.mousePosition.x / Screen.width * 0.30f;


        // GetComponent<RectTransform>().pivot = new Vector2(Input.mousePosition.x/Screen.width - 0.5f, 0.5f);

    }
    

    public void OnPointerUp(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.black;
        
        

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.red;
        
        

    }

}
