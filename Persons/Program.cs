using Persons;

var persons = new List<Person>();

var exit = false;
do
{
    ConsoleHelper.PrintMenu();
    var input = ConsoleHelper.Input("Введите пункт меню");
    switch (input)
    {
        case "1": // 1. Добавить
            var lastName = ConsoleHelper.Input("Введите фамилию");
            var firstName = ConsoleHelper.Input("Введите имя");
            persons.Add(new Person(lastName: lastName, firstName: firstName));
            /*
             * persons.Add(new Person(
                lastName: ConsoleHelper.Input("Введите фамилию"), 
                firstName: ConsoleHelper.Input("Введите имя")
                ));
             */
            break;
        case "2": // 2. Показать всех
            foreach (var person in persons)
            {
                ConsoleHelper.PrintPerson(person);
            }
            break;
        case "3": // 3. Найти по имени
            var name = ConsoleHelper.Input("Введите имя для поиска");
            foreach (var person in persons)
            {
                if (person.GetLastName() == name || person.GetFirstName() == name)
                {
                    ConsoleHelper.PrintPerson(person);
                }
            }
            break;
        case "0": // 0. Выйти
            exit = true;
            break;
        default:
            ConsoleHelper.PrintError("Неправильный ввод! Повторите!");
            break;
    }

} while (!exit);

ConsoleHelper.PrintInfo("До свидания ...");
