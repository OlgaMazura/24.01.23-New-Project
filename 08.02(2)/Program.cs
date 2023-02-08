//Дан текст. В тексте все пробелы нужно щаменить на черточки, 
//все маленькие буквы "к" на большие "К",  
//все большие "С" на маленькие "с".
Console.Clear();
string Text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия прусского короля. "
            + "вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345 - это нумерация, для обращения к конкретному символу строки
// s[3] - это буква "r"

string Replace(string Text, char OldValue, char NewValue)
{
    string Result = string.Empty;

    int length = Text.Length;
    for (int i = 0; i < length; i++)
    {
        if (Text[i] == OldValue) Result = Result + $"{NewValue}";
        else Result = Result + $"{Text[i]}";
    }
    return Result;
}

string NewText = Replace(Text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);