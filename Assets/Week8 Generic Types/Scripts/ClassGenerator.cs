using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// where T extends from Monobehavior.
public class ClassGenerator : MonoBehaviour
{
    [SerializeField]
    private int studentCount = 15;
    [SerializeField]
    private int teacherCount = 1;

    // fills classes by cloning and then returns them(?)
    private Cloner<Student> students = new Cloner<Student>();
    private Cloner<Teacher> teachers = new Cloner<Teacher>();


    // Start is called before the first frame update
    void Start()
    {

        students.ClonePeople(studentCount);
        
        teachers.ClonePeople(teacherCount);

        foreach(Student student in students.GetPeople())
            Debug.Log(student.ToString());

        foreach(Teacher teacher in teachers.GetPeople())
            Debug.Log(teacher.ToString());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
