
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







namespace cfg.error
{
    [Serializable]
    public partial class ErrorInfo : AConfig
    {
        public string  code { get; set; }

        public string  desc { get; set; }

        [JsonProperty]
        public error.ErrorStyle  style { get; set; }


        public override void EndInit() 
        {
            style.EndInit();
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            Style?.TranslateText(translator);
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
