public class FreakcatJson<T>
{
    public static T CreateObj(string json)
    {
        return JsonUtility.FromJson<T>(json);
    }

    public static string CreateStr(T t)
    {
        return JsonUtility.ToJson(t);
    }
}
