
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







namespace cfg.bonus
{
    [Serializable]
    public partial class ShowItemInfo : AConfig
    {
        [JsonProperty("item_id")]
        private int _item_id { get; set; }
        [JsonIgnore]
        public EncryptInt item_id { get; private set; } = new();

        [JsonProperty("item_num")]
        private long _item_num { get; set; }
        [JsonIgnore]
        public EncryptLong item_num { get; private set; } = new();


        public override void EndInit() 
        {
            item_id = _item_id;
            item_num = _item_num;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
