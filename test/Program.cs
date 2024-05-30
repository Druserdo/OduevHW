public class PasswordGenerator
{
    Random random = new Random();
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    string simvol = "~!@#$%^&*()_-+=<,>.?/|\\:;\"'[{]}";
    string password = "";
    public string LowerCase()
    {
        for (int i = 1; i <= 12; i++)
        {
            password += alphabet[random.Next(0, alphabet.Length + 1)];
        }
        return password.ToLower();
    }
    public string UpperCase()
    {
        for (int i = 1; i <= 12; i++)
        {
            password += alphabet[random.Next(0, alphabet.Length + 1)];
        }
        return password.ToUpper();
    }
    public string SivolCase()
    {
        for (int i = 1; i <= 12; i++)
        {
            password += simvol[random.Next(0, simvol.Length + 1)];
        }
        return password;
    }
    public string HeawyPass()
    {
        string temp = alphabet.ToLower() + alphabet.ToUpper() + simvol;
        for (int i = 1; i <= 12; i++)
        {
            password += temp[random.Next(0, temp.Length + 1)];
        }
        return password;
    }
}