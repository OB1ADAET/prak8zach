using Newtonsoft.Json;

namespace prak8
{
    public class Users
    {
        public string name;
        public int charsPerMinute; public float charsPerSecond;

        public Users(string nameArg, int charsPerMinuteArg)
        {
            name = nameArg;
            charsPerMinute = charsPerMinuteArg;
            charsPerSecond = (float)charsPerMinuteArg / 60;
        }

        public static List<Users> Serializing(string name, int index)
        {
            string json = File.ReadAllText("C:\\C#\\prak8\\record.json");
            List<Users> users = JsonConvert.DeserializeObject<List<Users>>(json);
            Users user = new Users(name, index);
            users.Add(user);

            json = JsonConvert.SerializeObject(users);
            File.WriteAllText("C:\\C#\\prak8\\record.json", json);

            return users;
        }
    }
}
