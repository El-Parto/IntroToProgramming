using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Polymorphism
/// Person being the base class to inherit classes
/// </summary>
public class CloningMachine : MonoBehaviour
{

    [SerializeField]
    private int studentCount = 15;// integer  variable named studentCount
    [SerializeField]
    private int teacherCount = 1;

    private List<Person> peeps = new List<Person>();


    // Start is called before the first frame update
    void Start()
    {

        // loops to add Student for everyone in studentCount.
        for(int i = 0; 1 < studentCount; i ++)
        {
            AddPerson(new Student()); //student is from Abstraction script in Wk7
        }

        for (int i = 0; 1 < teacherCount; i++) // a for loop, looping i, add Teacher for every one in peeps
        {
            AddPerson(new Teacher()); //student is from Abstraction script in Wk7

        }



    }
    //return an array of person - how to get teachers
    public List<Teacher> GetTeachers()
    {
        List<Teacher> teachers = new List<Teacher>();

        //looping through person

                                //needs type here
                                // v
        foreach (Person person in peeps)
        {
            if(person is Teacher)
            {
                //looping through person
                // is lets us check if a variable is of a specific type
                // this is mainly used for polymorphism
                teachers.Add(person as Teacher);
            }
        }

        return teachers;
        //we can now confirm every one coming from this function is a teacher
    }
    public List<Student> GetStudents()
    {
        List<Student> students = new List<Student>();

        //looping through person
        // is lets us check if a variable is of a specific type
        // this is mainly used for polymorphism
        foreach (Person person in peeps)
        {
            if(person is Student)
            {
                // as is a way of casting a variable to another type
                // in this case it is exactly the same as writing
                // (student)person
                students.Add(person as Student);
            }
        }


        return students;
        //we can now confirm every one coming from this function is a student
    }

    //doing it in reverse
    //passing it in as a variable
    public void AddPerson(Person _person) => peeps.Add(_person);//underscore is helpful with declaring parameter




    // Update is called once per frame
    void Update()
    {
        
    }
}
