
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







namespace cfg.ai
{
    [Serializable]
    public partial class DistanceLessThan : AConfig
    {
        public string  actor1_key { get; set; }

        public string  actor2_key { get; set; }

        [JsonProperty("distance")]
        private float _distance { get; set; }
        [JsonIgnore]
        public EncryptFloat distance { get; private set; } = new();

        public bool  reverse_result { get; set; }


        public override void EndInit() 
        {
            distance = _distance;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
