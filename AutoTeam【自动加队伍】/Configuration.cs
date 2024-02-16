using System;
using System.IO;
using Newtonsoft.Json;
using TShockAPI;

namespace autoteam
{
    public class Configuration
    {
        public static readonly string FilePath = Path.Combine(TShock.SavePath, "AutoTeam.json");

        [JsonProperty("组的队伍")]
        public Dictionary<string, string> GroupTeamMap { get; set; } = new Dictionary<string, string>
        {
            { "组名字", "队伍名称中文或英文" },
            { "default", "红队" },
            { "亲爱的", "red" },
            // 添加更多默认映射关系...
        };
        [JsonProperty("开启插件")]
        public bool Enabled = true;

        public string GetTeamForGroup(string groupName)
        {
            // 检查映射关系中是否包含给定的组名
            if (GroupTeamMap.ContainsKey(groupName))
                return GroupTeamMap[groupName];
            else
                return "none"; // 默认返回"无队伍"
        }


        public void Write(string path)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                var str = JsonConvert.SerializeObject(this, Formatting.Indented);
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(str);
                }
            }
        }

        public static Configuration Read(string path)
        {
            if (!File.Exists(path))
                return new Configuration();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var cf = JsonConvert.DeserializeObject<Configuration>(sr.ReadToEnd());
                    return cf;
                }
            }
        }
    }
}
