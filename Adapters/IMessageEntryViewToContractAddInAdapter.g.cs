//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Adapters
{
    
    public class IMessageEntryViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageEntryContract
    {
        private Start9.Views.IMessageEntry _view;
        public IMessageEntryViewToContractAddInAdapter(Start9.Views.IMessageEntry view)
        {
            _view = view;
        }
        public System.Type Type
        {
            get
            {
                return _view.Type;
            }
        }
        public string FriendlyName
        {
            get
            {
                return _view.FriendlyName;
            }
        }
        internal Start9.Views.IMessageEntry GetSourceView()
        {
            return _view;
        }
    }
}
