
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Nireus.Base;
using Nireus.Model;
using Newtonsoft.Json;







namespace cfg.condition
{
    [Serializable]
    public partial class MaxLevel : AConfig
    {
        [JsonProperty("level")]
        private int _level { get; set; }
        [JsonIgnore]
        public EncryptInt level { get; private set; } = new();


        public override void EndInit() 
        {
            level = _level;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
