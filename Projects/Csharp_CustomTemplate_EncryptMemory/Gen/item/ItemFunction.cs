
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
    [Serializable]
    public partial class ItemFunction : AConfig
    {
        public item.EMinorType  minor_type { get; set; }

        public item.EItemFunctionType  func_type { get; set; }

        public string  method { get; set; }

        public bool  close_bag_ui { get; set; }


        public override void EndInit() 
        {
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
