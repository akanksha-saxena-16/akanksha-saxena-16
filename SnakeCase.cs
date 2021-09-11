void Main()
{
	 static string ToSnakeCase(string text)
{
    if(text == null) {
        throw new ArgumentNullException(nameof(text));
    }
    if(text.Length < 2) {
        return text;
    }
    var sb = new StringBuilder();
    sb.Append(char.ToLowerInvariant(text[0]));
    for(int i = 1; i < text.Length; ++i) {
        char c = text[i];
        if(char.IsUpper(c)) {
            sb.Append('_');
            sb.Append(char.ToLowerInvariant(c));
        } else {
            sb.Append(c);
        }
    }
    return sb.ToString();
}
string text = "thisStringValue";
string snakeCaseText = ToSnakeCase(text);
Console.WriteLine(snakeCaseText);
}

// You can define other methods, fields, classes and namespaces here
