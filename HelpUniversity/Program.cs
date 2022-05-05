using Secretary;

Console.WriteLine("hello");
//////////////////////////////////////////////////////////
/* 4 persone inserite nel DB

var person1 = new handlerPerson();
person1.InserisciUnaPersona1();

var person2 = new handlerPerson();
person1.InserisciUnaPersona2();

var person3 = new handlerPerson();
person3.InserisciUnaPersona1();

var person4 = new handlerPerson();
person4.InserisciUnaPersona4();*/

//////////////////////////////////////////////////////
/* prensenti nel DB 2 TEACHER
var Teacher1 = new handlerTeacher();
Teacher1.InserisciTeacher2();  */

/////////////////////////////////////////////////
/* 5 STUDENTI  PRESENTI NEL DB 

var student2 = new hadlerStudent();
student2.InserisciStudent2();

var student3 = new hadlerStudent();
student3.InserisciStudent3();

var student4 = new hadlerStudent();
student4.InserisciStudent4();

var student5 = new hadlerStudent();
student5.InserisciStudent5(); */

//////////////////////////////////////////////////////////

/* INSERITI NEL DB 5 SUBJECT

var subject2=new hanlerSubject();
subject2.InserireSubject2();

var subject3 = new hanlerSubject();
subject3.InserireSubject3();

var subject4 = new hanlerSubject();
subject4.InserireSubject4();

var subject5 = new hanlerSubject();
subject5.InserireSubject5();*/

//////////////////////////////////////////////////////

//AGGIUNTI  5 LESSON NEL DB
/*var lesson = new handlerLesson();
lesson.AggiugiLesson();

var lesson2 = new handlerLesson();
lesson2.AggiugiLesson2();

var lesson3 = new handlerLesson();
lesson3.AggiugiLesson3();

var lesson4 = new handlerLesson();
lesson4.AggiugiLesson4();

var lesson5 = new handlerLesson();
lesson5.AggiugiLesson5();*/
////////////////////////////////////////////////////////////////////
/* AGGIUNTI AL DB 3 CLASS 
var class1 = new handlerClass();
class1.AggiugiClass1();

var class2 = new handlerClass();
class2.AggiugiClass2();

var class3 = new handlerClass();
class3.AggiugiClass3();*/

//////////////////////////////////////////
/* AGGIUNTI 5 EXAM NEL DATABSE

var exam1 = new handlerExam();
exam1.AggiugiExam1();

var exam2 = new handlerExam();
exam2.AggiugiExam2();

var exam3 = new handlerExam();
exam3.AggiugiExam3();

var exam4 = new handlerExam();
exam4.AggiugiExam4();

var exam5 = new handlerExam();
exam5.AggiugiExam5();*/

/////////////////////////////////
/* AGGIUNTI 8 DETTAGLI ESAMI

var examdetails1 = new handlerExamDetails();
examdetails1.aggiugniExamDetails1();

var examdetails2 = new handlerExamDetails();
examdetails2.aggiugniExamDetails2();

var examdetails3 = new handlerExamDetails();
examdetails3.aggiugniExamDetails3();

var examdetails4 = new handlerExamDetails();
examdetails4.aggiugniExamDetails4();

var examdetails5 = new handlerExamDetails();
examdetails5.aggiugniExamDetails5();*/

var handler = new handlerRequestToSecretary();

var personEnumerable = handler.GetPersone("rossi");


foreach (var item in personEnumerable)
{
    Console.WriteLine($"{item.Name} {item.Surname} ");
}





