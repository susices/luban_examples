
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
    public partial class Item : AConfig
    {
        [JsonProperty("item_id")]
        private int _item_id { get; set; }
        [JsonIgnore]
        public EncryptInt item_id { get; private set; } = new();

        [JsonProperty("amount")]
        private int _amount { get; set; }
        [JsonIgnore]
        public EncryptInt amount { get; private set; } = new();


        public override void EndInit() 
        {
            item_id = _item_id;
            amount = _amount;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
