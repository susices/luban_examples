
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
    public partial class InnerGroup : AConfig
    {
        [JsonProperty("y1")]
        private int _y1 { get; set; }
        [JsonIgnore]
        public EncryptInt y1 { get; private set; } = new();

        [JsonProperty("y2")]
        private int _y2 { get; set; }
        [JsonIgnore]
        public EncryptInt y2 { get; private set; } = new();

        [JsonProperty("y3")]
        private int _y3 { get; set; }
        [JsonIgnore]
        public EncryptInt y3 { get; private set; } = new();

        [JsonProperty("y4")]
        private int _y4 { get; set; }
        [JsonIgnore]
        public EncryptInt y4 { get; private set; } = new();


        public override void EndInit() 
        {
            y1 = _y1;
            y2 = _y2;
            y3 = _y3;
            y4 = _y4;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
