Console.Clear();
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "+
"ежели бы вас послали вместо нашего милого " +
"Винценгероде, вы бы взяли приступом согласие "+
"прусского короля. Вы так красноречивы. Вы "+
"дадите мне чаю?";

string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

string Replace(string txt, char oldChar, char newChar)
{
    string result = string.Empty;
    for(int i = 0; i < text.Length; i++){
        if(text[i] == oldChar) result = result + $"{newChar}";
        else result= result + $"{txt[i]}";
    }

    return result;
}