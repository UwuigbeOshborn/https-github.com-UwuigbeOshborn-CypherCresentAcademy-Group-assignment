using ConsoleApp5;

int count, count2, count3;
string username, selectedOption, selectedOption2, selectedOption3, selectedOption4, selectedOption5, selectedOption6, selectedOption7, selectedOption8;

Console.Write("---------------------------------------------------------------------------------------------------------------------------------\n");
Console.Write("            ********************    WELCOME TO GROUP 2 DATABASE MANAGEMENT SYSTEM    ********************\n");
Console.Write("---------------------------------------------------------------------------------------------------------------------------------\n\n");

Console.Write("Please enter Username: ");
username = Convert.ToString(Console.ReadLine());

count = 0;
while (count < 5)
{
    Console.Write("\n\nHello {0} would you like to;\n\n", username);
    Console.Write("1.) Access existing database? if yes enter 1\n");
    Console.Write("2.) Make changes on existing database? if yes enter 2\n");
    Console.Write("3.) Reset existing database? if yes enter 3\n");
    Console.Write("4.) Else, enter NO\n");
    Console.Write("\nPlease choose: ");
    selectedOption = Convert.ToString(Console.ReadLine());

    if (selectedOption != "1" && selectedOption != "2" && selectedOption != "3" && selectedOption != "NO")
    {
        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
        Console.Write("Would you like to try again? YES or NO: ");
        selectedOption2 = Convert.ToString(Console.ReadLine());
        if (selectedOption2 == "YES")
        {
            count += 1;
        }
        else if (selectedOption2 == "NO")
        {
            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
            break;
        }
        else
        {
            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
            break;
        }
    }

    if (selectedOption == "NO")
    {
        break;
    }


    if (selectedOption == "1")
    {
        count2 = 0;
        while (count2 < 5)
        {
            Console.Write("----------------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("                                  **********       Accessing existing database       **********\n");
            Console.Write("----------------------------------------------------------------------------------------------------------------------------\n\n");
            Console.Write("\n\nHello {0} would you like to;\n\n", username);
            Console.Write("1.) Access all database info? if yes enter 1\n");
            Console.Write("2.) Else, enter NO\n");
            Console.Write("\nPlease choose: ");
            selectedOption3 = Convert.ToString(Console.ReadLine());

            if (selectedOption3 != "1" && selectedOption3 != "2" && selectedOption3 != "3" && selectedOption3 != "4" && selectedOption3 != "5" && selectedOption3 != "NO")
            {
                Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                Console.Write("Would you like to try again? YES or NO: ");
                selectedOption4 = Convert.ToString(Console.ReadLine());
                if (selectedOption4 == "YES")
                {
                    count2 += 1;
                }
                else if (selectedOption4 == "NO")
                {
                    Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                    break;
                }
                else
                {
                    Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                    break;
                }
            }

            if (selectedOption3 == "NO")
            {
                break;
            }

            if (selectedOption3 == "1")
            {
                //Console.Write("\nEnter school Id: ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("\nEnter school name: ");
                //string name = Convert.ToString(Console.ReadLine());
                //Console.Write("\nEnter school address: ");
                //string address = Convert.ToString(Console.ReadLine());

                //var school = new School() { Id = id, Name = name, Address = address };
                //FluentNHibernateHelper.ReadItem(school);

                //Console.Write("\nEnter student Id: ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("\nEnter student fullame: ");
                //string fullName = Convert.ToString(Console.ReadLine());
                //Console.Write("\nEnter student school name: ");
                //School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                //Console.Write("\nEnter student assigned classroom name: ");
                //ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                //var teacher = new Teacher() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                //FluentNHibernateHelper.ReadItem(teacher);

                //Console.Write("\nEnter student Id: ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("\nEnter student fullame: ");
                //string fullName = Convert.ToString(Console.ReadLine());
                //Console.Write("\nEnter student school name: ");
                //School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                //Console.Write("\nEnter student assigned classroom name: ");
                //ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                //var student = new Student() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                //FluentNHibernateHelper.ReadItem(student);

                //Console.Write("\nEnter clasroom Id: ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("\nEnter clasroom name: ");
                //string name = Convert.ToString(Console.ReadLine());

                //var subject = new Subject() { Id = id, Name = name };
                //FluentNHibernateHelper.ReadItem(subject);

                //Console.Write("\nEnter clasroom Id: ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("\nEnter clasroom name: ");
                //string name = Convert.ToString(Console.ReadLine());
                //Console.Write("\nEnter school name: ");
                //School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                //Console.Write("\nEnter teacher(incharge of class) fullname: ");
                //Teacher teacher = new Teacher() { FullName = Convert.ToString(Console.ReadLine()) };

                //var classRoom = new ClassRoom() { Id = id, Name = name, School = school, Teacher = teacher };
                //FluentNHibernateHelper.ReadItem(classRoom);


                break;
            }
        }
    }

    if (selectedOption == "2")
    {
        count2 = 0;
        while (count2 < 5)
        {
            Console.Write("-----------------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("                          **********       Make changes on existing database       **********\n");
            Console.Write("-----------------------------------------------------------------------------------------------------------------------------\n\n");
            Console.Write("\n\nHello {0} would you like to;\n\n", username);
            Console.Write("1.) Make changes on 'School's' database? if yes enter 1\n");
            Console.Write("2.) Make changes on 'Teacher's' database? if yes enter 2\n");
            Console.Write("3.) Make changes on 'Student's' database? if yes enter 3\n");
            Console.Write("4.) Make changes on 'Subject's' database? if yes enter 4\n");
            Console.Write("5.) Make changes on 'Clasroom's' database? if yes enter 5\n");
            Console.Write("6.) Else, enter NO\n");
            Console.Write("\nPlease choose: ");
            selectedOption5 = Convert.ToString(Console.ReadLine());

            if (selectedOption5 != "1" && selectedOption5 != "2" && selectedOption5 != "3" && selectedOption5 != "4" && selectedOption5 != "5" && selectedOption5 != "NO")
            {
                Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                Console.Write("Would you like to try again? YES or NO: ");
                selectedOption6 = Convert.ToString(Console.ReadLine());
                if (selectedOption6 == "YES")
                {
                    count2 += 1;
                }
                else if (selectedOption6 == "NO")
                {
                    Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                    break;
                }
                else
                {
                    Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                    break;
                }
            }

            if (selectedOption5 == "NO")
            {
                break;
            }


            if (selectedOption5 == "1")
            {
                count3 = 0;
                while (count3 < 5)
                {
                    Console.Write("---------------------------------------------------------------------------------------------------------------------------------\n");
                    Console.Write("                                  **********       Make changes on existing database       **********\n");
                    Console.Write("---------------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.Write("\n\nHello {0} would you like to;\n\n", username);
                    Console.Write("1.) Create new school row? if yes enter 1\n");
                    Console.Write("2.) Read school row? if yes enter 2\n");
                    Console.Write("3.) Update school row? if yes enter 3\n");
                    Console.Write("4.) Delete school row? if yes enter 4\n");
                    Console.Write("5.) Else, enter NO\n");
                    Console.Write("\nPlease choose: ");
                    selectedOption7 = Convert.ToString(Console.ReadLine());

                    if (selectedOption7 != "1" && selectedOption7 != "2" && selectedOption7 != "3" && selectedOption7 != "4" && selectedOption7 != "5" && selectedOption7 != "NO")
                    {
                        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                        Console.Write("Would you like to try again? YES or NO: ");
                        selectedOption8 = Convert.ToString(Console.ReadLine());
                        if (selectedOption8 == "YES")
                        {
                            count3 += 1;
                        }
                        else if (selectedOption8 == "NO")
                        {
                            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                            break;
                        }
                        else
                        {
                            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                            break;
                        }
                    }

                    
                    if (selectedOption7 == "NO")
                    {
                        break;
                    }

                    if (selectedOption7 == "1")
                    {
                        Console.Write("\nEnter school Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school address: ");
                        string address = Convert.ToString(Console.ReadLine());

                        var school = new School() { Id = id, Name = name, Address = address };
                        FluentNHibernateHelper.AddItem(school);
                        break;
                    }

                    if (selectedOption7 == "2")
                    {
                        Console.Write("\nEnter school Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school address: ");
                        string address = Convert.ToString(Console.ReadLine());

                        var school = new School() { Id = id, Name = name, Address = address };
                        FluentNHibernateHelper.ReadItem(school.Id, school);
                        break;
                    }

                    if (selectedOption7 == "3")
                    {
                        Console.Write("\nEnter school Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school address: ");
                        string address = Convert.ToString(Console.ReadLine());

                        var school = new School() { Id = id, Name = name, Address = address };
                        FluentNHibernateHelper.UpdateItem(school);
                        break;
                    }

                    if (selectedOption7 == "4")
                    {
                        Console.Write("\nEnter school Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school address: ");
                        string address = Convert.ToString(Console.ReadLine());

                        var school = new School() { Id = id, Name = name, Address = address };
                        FluentNHibernateHelper.DeleteItem(school);
                        break;
                    }
                }
            }

            if (selectedOption5 == "2")
            {
                count3 = 0;
                while (count3 < 5)
                {
                    Console.Write("----------------------------------------------------------------------------------------------------------------------------\n");
                    Console.Write("                                  **********       Make changes on existing database       **********\n");
                    Console.Write("----------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.Write("\n\nHello {0} would you like to;\n\n", username);
                    Console.Write("1.) Create new teacher row? if yes enter 1\n");
                    Console.Write("2.) Read teacher row? if yes enter 2\n");
                    Console.Write("3.) Update teacher row? if yes enter 3\n");
                    Console.Write("4.) Delete teacher row? if yes enter 4\n");
                    Console.Write("5.) Else, enter NO\n");
                    Console.Write("\nPlease choose: ");
                    selectedOption7 = Convert.ToString(Console.ReadLine());

                    if (selectedOption7 != "1" && selectedOption7 != "2" && selectedOption7 != "3" && selectedOption7 != "4" && selectedOption7 != "5" && selectedOption7 != "NO")
                    {
                        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                        Console.Write("Would you like to try again? YES or NO: ");
                        selectedOption8 = Convert.ToString(Console.ReadLine());
                        if (selectedOption8 == "YES")
                        {
                            count3 += 1;
                        }
                        else if (selectedOption8 == "NO")
                        {
                            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                            break;
                        }
                        else
                        {
                            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                            break;
                        }
                    }

                    
                    if (selectedOption7 == "NO")
                    {
                        break;
                    }

                    if (selectedOption7 == "1")
                    {
                        Console.Write("\nEnter teacher Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter teacher fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter teacher school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var teacher = new Teacher() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.AddItem(teacher);
                        break;
                    }

                    if (selectedOption7 == "2")
                    {
                        Console.Write("\nEnter teacher Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter teacher fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter teacher school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var teacher = new Teacher() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.ReadItem(teacher);
                        break;
                    }

                    if (selectedOption7 == "3")
                    {
                        Console.Write("\nEnter teacher Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter teacher fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter teacher school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var teacher = new Teacher() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.UpdateItem(teacher);
                        break;
                    }

                    if (selectedOption7 == "4")
                    {
                        Console.Write("\nEnter teacher Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter teacher fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter teacher school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var teacher = new Teacher() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.DeleteItem(teacher);
                        break;
                    }
                }
            }

            if (selectedOption5 == "3")
            {
                count3 = 0;
                while (count3 < 5)
                {
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n");
                    Console.Write("                                  **********       Make changes on existing database       **********\n");
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.Write("\n\nHello {0} would you like to;\n\n", username);
                    Console.Write("1.) Create new student row? if yes enter 1\n");
                    Console.Write("2.) Read student row? if yes enter 2\n");
                    Console.Write("3.) Update student row? if yes enter 3\n");
                    Console.Write("4.) Delete student row? if yes enter 4\n");
                    Console.Write("5.) Else, enter NO\n");
                    Console.Write("\nPlease choose: ");
                    selectedOption7 = Convert.ToString(Console.ReadLine());

                    if (selectedOption7 != "1" && selectedOption7 != "2" && selectedOption7 != "3" && selectedOption7 != "4" && selectedOption7 != "5" && selectedOption7 != "NO")
                    {
                        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                        Console.Write("Would you like to try again? YES or NO: ");
                        selectedOption8 = Convert.ToString(Console.ReadLine());
                        if (selectedOption8 == "YES")
                        {
                            count3 += 1;
                        }
                        else if (selectedOption8 == "NO")
                        {
                            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                            break;
                        }
                        else
                        {
                            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                            break;
                        }
                    }

                    
                    if (selectedOption7 == "NO")
                    {
                        break;
                    }

                    if (selectedOption7 == "1")
                    {
                        Console.Write("\nEnter student Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter student fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter student school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter student assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var student = new Student() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.AddItem(student);
                        break;
                    }

                    if (selectedOption7 == "2")
                    {
                        Console.Write("\nEnter student Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter student fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter student school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter student assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var student = new Student() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.ReadItem(student);
                        break;
                    }

                    if (selectedOption7 == "3")
                    {
                        Console.Write("\nEnter student Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter student fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter student school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter student assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var student = new Student() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.UpdateItem(student);
                        break;
                    }

                    if (selectedOption7 == "4")
                    {
                        Console.Write("\nEnter student Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter student fullame: ");
                        string fullName = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter student school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter student assigned classroom name: ");
                        ClassRoom classroom = new ClassRoom() { Name = Convert.ToString(Console.ReadLine()) };

                        var student = new Student() { Id = id, FullName = fullName, School = school, ClassRoom = classroom };
                        FluentNHibernateHelper.DeleteItem(student);
                        break;
                    }
                }
            }

            if (selectedOption5 == "4")
            {
                count3 = 0;
                while (count3 < 5)
                {
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n");
                    Console.Write("                                  **********       Make changes on existing database       **********\n");
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.Write("\n\nHello {0} would you like to;\n\n", username);
                    Console.Write("1.) Create new subject row? if yes enter 1\n");
                    Console.Write("2.) Read subject row? if yes enter 2\n");
                    Console.Write("3.) Update subject row? if yes enter 3\n");
                    Console.Write("4.) Delete subject row? if yes enter 4\n");
                    Console.Write("5.) Else, enter NO\n");
                    Console.Write("\nPlease choose: ");
                    selectedOption7 = Convert.ToString(Console.ReadLine());

                    if (selectedOption7 != "1" && selectedOption7 != "2" && selectedOption7 != "3" && selectedOption7 != "4" && selectedOption7 != "5" && selectedOption7 != "NO")
                    {
                        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                        Console.Write("Would you like to try again? YES or NO: ");
                        selectedOption8 = Convert.ToString(Console.ReadLine());
                        if (selectedOption8 == "YES")
                        {
                            count3 += 1;
                        }
                        else if (selectedOption8 == "NO")
                        {
                            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                            break;
                        }
                        else
                        {
                            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                            break;
                        }
                    }

                    
                    if (selectedOption7 == "NO")
                    {
                        break;
                    }

                    if (selectedOption7 == "1")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());

                        var subject = new Subject() { Id = id, Name = name};
                        FluentNHibernateHelper.AddItem(subject);
                        break;
                    }

                    if (selectedOption7 == "2")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());

                        var subject = new Subject() { Id = id, Name = name};
                        FluentNHibernateHelper.ReadItem(subject);
                        break;
                    }

                    if (selectedOption7 == "3")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());

                        var subject = new Subject() { Id = id, Name = name};
                        FluentNHibernateHelper.UpdateItem(subject);
                        break;
                    }

                    if (selectedOption7 == "4")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());

                        var subject = new Subject() { Id = id, Name = name};
                        FluentNHibernateHelper.DeleteItem(subject);
                        break;
                    }
                }
            }

            if (selectedOption5 == "5")
            {
                count3 = 0;
                while (count3 < 5)
                {
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n");
                    Console.Write("                                  **********       Make changes on existing database       **********\n");
                    Console.Write("--------------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.Write("\n\nHello {0} would you like to;\n\n", username);
                    Console.Write("1.) Create new clasroom row? if yes enter 1\n");
                    Console.Write("2.) Read clasroom row? if yes enter 2\n");
                    Console.Write("3.) Update clasroom row? if yes enter 3\n");
                    Console.Write("4.) Delete clasroom row? if yes enter 4\n");
                    Console.Write("5.) Else, enter NO\n");
                    Console.Write("\nPlease choose: ");
                    selectedOption7 = Convert.ToString(Console.ReadLine());

                    if (selectedOption7 != "1" && selectedOption7 != "2" && selectedOption7 != "3" && selectedOption7 != "4" && selectedOption7 != "5" && selectedOption7 != "NO")
                    {
                        Console.Write("\n\nOops! {0} it seems you entered a wrong option;\n", username);
                        Console.Write("Would you like to try again? YES or NO: ");
                        selectedOption8 = Convert.ToString(Console.ReadLine());
                        if (selectedOption8 == "YES")
                        {
                            count3 += 1;
                        }
                        else if (selectedOption8 == "NO")
                        {
                            Console.Write("\n\nOkay, goodbye {0}, we will see another time;\n", username);
                            break;
                        }
                        else
                        {
                            Console.Write("\n\nOops! {0} it seems you entered a wrong option again. Goodbye;\n", username);
                            break;
                        }
                    }

                    
                    if (selectedOption7 == "NO")
                    {
                        break;
                    }

                    if (selectedOption7 == "1")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher(incharge of class) fullname: ");
                        Teacher teacher = new Teacher() { FullName = Convert.ToString(Console.ReadLine()) };

                        var classRoom = new ClassRoom() { Id = id, Name = name, School = school, Teacher = teacher };
                        FluentNHibernateHelper.AddItem(classRoom);
                        break;
                    }

                    if (selectedOption7 == "2")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher(incharge of class) fullname: ");
                        Teacher teacher = new Teacher() { FullName = Convert.ToString(Console.ReadLine()) };

                        var classRoom = new ClassRoom() { Id = id, Name = name, School = school, Teacher = teacher };
                        FluentNHibernateHelper.ReadItem(classRoom);
                        break;
                    }

                    if (selectedOption7 == "3")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher(incharge of class) fullname: ");
                        Teacher teacher = new Teacher() { FullName = Convert.ToString(Console.ReadLine()) };

                        var classRoom = new ClassRoom() { Id = id, Name = name, School = school, Teacher = teacher };
                        FluentNHibernateHelper.UpdateItem(classRoom);
                        break;
                    }

                    if (selectedOption7 == "4")
                    {
                        Console.Write("\nEnter clasroom Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter clasroom name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter school name: ");
                        School school = new School() { Name = Convert.ToString(Console.ReadLine()) };
                        Console.Write("\nEnter teacher(incharge of class) fullname: ");
                        Teacher teacher = new Teacher() { FullName = Convert.ToString(Console.ReadLine()) };

                        var classRoom = new ClassRoom() { Id = id, Name = name, School = school, Teacher = teacher };
                        FluentNHibernateHelper.DeleteItem(classRoom);
                        break;
                    }
                }
            }
        }
    }
    if (selectedOption == "3")
    {
        Console.Write("----------------------------------------------------------------------------------------------------------------------------\n");
        Console.Write("                                  **********       Reseting existing database       **********\n");
        Console.Write("----------------------------------------------------------------------------------------------------------------------------\n\n");
        FluentNHibernateHelper.ResetSessionFactory();
    }
}