
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.mail
{

public sealed class GlobalMail :  Bright.Config.BeanBase 
{
    public GlobalMail(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Title = _buf.ReadString();
        Sender = _buf.ReadString();
        Content = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Award = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); Award.Add(_e);}}
        AllServer = _buf.ReadBool();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ServerList = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); ServerList.Add(_e);}}
        Platform = _buf.ReadString();
        Channel = _buf.ReadString();
        MinMaxLevel = condition.MinMaxLevel.DeserializeMinMaxLevel(_buf);
        RegisterTime = condition.TimeRange.DeserializeTimeRange(_buf);
        MailTime = condition.TimeRange.DeserializeTimeRange(_buf);
    }

    public static GlobalMail DeserializeGlobalMail(ByteBuf _buf)
    {
        return new mail.GlobalMail(_buf);
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Sender { get; private set; }
    public string Content { get; private set; }
    public System.Collections.Generic.List<int> Award { get; private set; }
    public bool AllServer { get; private set; }
    public System.Collections.Generic.List<int> ServerList { get; private set; }
    public string Platform { get; private set; }
    public string Channel { get; private set; }
    public condition.MinMaxLevel MinMaxLevel { get; private set; }
    public condition.TimeRange RegisterTime { get; private set; }
    public condition.TimeRange MailTime { get; private set; }

    public const int __ID__ = -287571791;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        MinMaxLevel?.Resolve(_tables);
        RegisterTime?.Resolve(_tables);
        MailTime?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        MinMaxLevel?.TranslateText(translator);
        RegisterTime?.TranslateText(translator);
        MailTime?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Title:" + Title + ","
        + "Sender:" + Sender + ","
        + "Content:" + Content + ","
        + "Award:" + Bright.Common.StringUtil.CollectionToString(Award) + ","
        + "AllServer:" + AllServer + ","
        + "ServerList:" + Bright.Common.StringUtil.CollectionToString(ServerList) + ","
        + "Platform:" + Platform + ","
        + "Channel:" + Channel + ","
        + "MinMaxLevel:" + MinMaxLevel + ","
        + "RegisterTime:" + RegisterTime + ","
        + "MailTime:" + MailTime + ","
        + "}";
    }
    }

}
