using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperators : MonoBehaviour
{
    [SerializeField]
    private bool isSprinting = false;
    [SerializeField] private bool isCrouching = false;
    [SerializeField] private float moveSpeed = 1;
    [SerializeField] private float sprintSpeed = 2;
    [SerializeField] private float crouchSpeed = .5f;

    // Update is called once per frame
    void Update()
    {
        /// Unary Operator assignment
        /// float speed = 0
        ///  if (isSpringing) speed = spring speed
        ///  else speed = moveSpeed
        ///  
        /// (single) Ternary operator assignment
        ///  condition ? true : false
        ///  ? = if - the question
        ///  : = else
        ///  True = if the contion was true, we do this
        ///  false = if the condiion was false, do this
        ///
        //float speed = isSprinting ? sprintSpeed : moveSpeed; // this is a single
        //            condition     true          false


        ///  it's also possible to nest ternary operators 
        ///  (Ternary operators within ternary operators.)
        ///  Nested Ternary Operator assignment
        ///  ternary oparators can be placed within each other to chain them
        ///  like tgus when we need to handle more than one case
        ///  the standard is to only have a maximum of 3 ternary operators nested
        ///  can't have standard conditions, only returns or assigns.

        //float speed = isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed;
        //            condition     true       else      false if true    else   false
        //float speed = GetMoveSpeed();

        //because when you pass in informatio as a parameter it is setting 
        // the value of the parameter, you can use a ternary operator
        Move(isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed);
       // can't be used in loops.


        

    }

    
    private void Move( float _speed)
        => transform.position += transform.forward * _speed * Time.deltaTime;

    // Ternary operators can also be used in return statements.
    private float GetMoveSpeed() => isCrouching ? crouchSpeed : isSprinting ? sprintSpeed : moveSpeed;
}
