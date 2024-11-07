using linQ;

namespace linQ;

public record dStudent ( string first, string last , int age, int id , int [] grades)

using WalkthroughWritingLinqQueries;

// Create a data source by using a collection initializer.
IEnumerable<Student> students =
[
    new Student(First: "Svetlana", Last: "Omelchenko", ID: 111, Scores: [97, 92, 81, 60]),
    new Student(First: "Claire",   Last: "O'Donnell",  ID: 112, Scores: [75, 84, 91, 39]),
    new Student(First: "Sven",     Last: "Mortensen",  ID: 113, Scores: [88, 94, 65, 91]),
    new Student(First: "Cesar",    Last: "Garcia",     ID: 114, Scores: [97, 89, 85, 82]),
    new Student(First: "Debra",    Last: "Garcia",     ID: 115, Scores: [35, 72, 91, 70]),
    new Student(First: "Fadi",     Last: "Fakhouri",   ID: 116, Scores: [99, 86, 90, 94]),
    new Student(First: "Hanying",  Last: "Feng",       ID: 117, Scores: [93, 92, 80, 87]),
    new Student(First: "Hugo",     Last: "Garcia",     ID: 118, Scores: [92, 90, 83, 78]),

    new Student("Lance",   "Tucker",      119, [68, 79, 88, 92]),
    new Student("Terry",   "Adams",       120, [99, 82, 81, 79]),
    new Student("Eugene",  "Zabokritski", 121, [96, 85, 91, 60]),
    new Student("Michael", "Tucker",      122, [94, 92, 91, 91])
];


// Consulta para filtrar estudiantes con una puntuación superior a 90
IEnumerable<Student> studentQuery = 
    from student in students
    where student.Scores[0] > 90
    orderby student.Scores[0] descending;
    select student;

// Imprime información de los estudiantes filtrados
foreach (Student item in studentQuery) // Cambiado 'student' a 'item' para evitar confusión
{
    Console.WriteLine($"Nombre de alumno: {item.First}, Apellido: {item.Last}, Id de alumno: {item.Id}");
}

// Agrupa estudiantes por la primera letra de su apellido
IEnumerable<IGrouping<char, Student>> groupedStudents =
    from student in students
    group student by student.Last[0] into studentGroup
    orderby studentGroup.Key // Ordena por la letra del apellido
    select studentGroup;

    foreach (Igrouping<char , Student> studentGroup in studetnquery){
        console.WriteLine(studentGroup.key);}


    foreach(Student student in studentgroup ){
        console.WriteLine($"First name: {first} Last name: {last} , ID: {id}");

    }


    IEnumerable<IGrouping<char, Student>> studentQuery =
    from students in studentGroup
    group studen by student.Last[0];


