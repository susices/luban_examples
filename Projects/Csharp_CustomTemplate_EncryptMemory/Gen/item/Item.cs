
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







namespace cfg.item
{
	/// <summary>
	/// 道具
	/// </summary>
    [Serializable]
    public partial class Item : AConfig
    {

        public string  name { get; set; }

        public item.EMajorType  major_type { get; set; }

        public item.EMinorType  minor_type { get; set; }

        [JsonProperty("max_pile_num")]
        private int _max_pile_num { get; set; }
        [JsonIgnore]
        public EncryptInt max_pile_num { get; private set; } = new();

        public item.EItemQuality  quality { get; set; }

        public string  icon { get; set; }

        public string  icon_backgroud { get; set; }

        public string  icon_mask { get; set; }

        public string  desc { get; set; }

        [JsonProperty("show_order")]
        private int _show_order { get; set; }
        [JsonIgnore]
        public EncryptInt show_order { get; private set; } = new();

        public string  quantifier { get; set; }

        public bool  show_in_bag { get; set; }

        [JsonProperty("min_show_level")]
        private int _min_show_level { get; set; }
        [JsonIgnore]
        public EncryptInt min_show_level { get; private set; } = new();

        public bool  batch_usable { get; set; }

        [JsonProperty("progress_time_when_use")]
        private float _progress_time_when_use { get; set; }
        [JsonIgnore]
        public EncryptFloat progress_time_when_use { get; private set; } = new();

        public bool  show_hint_when_use { get; set; }

        public bool  droppable { get; set; }

        [JsonProperty("price")]
        private int? _price { get; set; }
        [JsonIgnore]
        public EncryptInt price { get; private set; } = new();

        public item.EUseType  use_type { get; set; }

        [JsonProperty("level_up_id")]
        private int? _level_up_id { get; set; }
        [JsonIgnore]
        public EncryptInt level_up_id { get; private set; } = new();


        public override void EndInit() 
        {
            max_pile_num = _max_pile_num;
            show_order = _show_order;
            min_show_level = _min_show_level;
            progress_time_when_use = _progress_time_when_use;
            price = _price;
            level_up_id = _level_up_id;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
