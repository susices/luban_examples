
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







namespace cfg.test
{
    [Serializable]
    public partial class NotIndexList : AConfig
    {
        [JsonProperty("x")]
        private int _x { get; set; }
        [JsonIgnore]
        public EncryptInt x { get; private set; } = new();

        [JsonProperty("y")]
        private int _y { get; set; }
        [JsonIgnore]
        public EncryptInt y { get; private set; } = new();


        public override void EndInit() 
        {
            x = _x;
            y = _y;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
