
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Newtonsoft.Json.Linq;

namespace cfg
{
public partial class Tables
{
    public TbGlobal TbGlobal {get; }


      public Tables(System.Func<string, JArray> loader)
    {
        TbGlobal = new TbGlobal(loader("tbglobal"));
        ResolveRef();
    }
    
     private void ResolveRef()
    {
        TbGlobal.ResolveRef(this);
    }
}

}

