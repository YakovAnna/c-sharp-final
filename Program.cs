string[] test = { "Hello", "2", "world", ":-)" };
string[] expected = {"2", ":-)"};
Console.WriteLine(
    "First test: expected={0} : actual={1}",
    string.Join(", ", expected),
    string.Join(", ", toSmall(test))
);

test = new string[] { "1234", "1567", "-2", "computer science" };
expected = new string[] {"-2"};
Console.WriteLine(
    "Second test: expected={0} : actual={1}",
    string.Join(", ", expected),
    string.Join(", ", toSmall(test))
);


test = new string[] { "Russia", "Denmark", "Kazan" };
expected = new string[] {};
Console.WriteLine(
    "Third test: expected={0} : actual={1}",
    string.Join(", ", expected),
    string.Join(", ", toSmall(test))
);

string[] toSmall(string[] seq)
{
    // Найдем кол-во подходящих строк
    int sum = 0;
    for (int i = 0; i < seq.Length; i++) {
        if (seq[i].Length <= 3) {
            sum += 1;
        }
    }

    // Сформируем результирующий массив
    string[] result = new string[sum];
    for (int i = 0, j = 0; i < seq.Length; i++) {
        if (seq[i].Length <= 3) {
            result[j] = seq[i];
            j += 1;
        }
    }

    // Вернем результат
    return result;
}
