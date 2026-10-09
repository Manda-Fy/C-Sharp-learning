namespace GitComm;
class Description()
{
    public static string GiveDescription(string desc)
    {
        desc = desc.Trim();
        desc = desc.ToLower();
        if (desc.EndsWith('.'))
        {
            int lenght = desc.Length;
            desc = desc.Substring(0, lenght-1);
            desc = desc.Trim();
            return desc; 
        }
        return desc;
    }
}