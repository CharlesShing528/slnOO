using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Inherited_01
{
    // ChangeRequest derives from WorkItem and adds a property (originalItemID) 
    // and two constructors.
    /* ChangeRequest從WorkItem派生
    *，並添加一個屬性（originalItemID）和兩個構造函數。
    */ 
    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        // Constructors. Because neither constructor calls a base-class 
        // constructor explicitly, the default constructor in the base class
        // is called implicitly. The base class must contain a default 
        // constructor.
        /* 構造 函數。由於建構函式都不顯式調用基類建構函式，因此基類中的預設建構函式是隱式調用的。
         * 基類必須包含預設建構函式。
         */
        // Default constructor for the derived class.
        // 衍生類的預設建構函式。
        public ChangeRequest() { }

        // Instance constructor that has four parameters.
        // 具有四個參數的實例建構函數。
        public ChangeRequest(string title, string desc, TimeSpan jobLen,
                             int originalID)
        {
            // The following properties and the GetNexID method are inherited 
            // from WorkItem.
            // 以下屬性和GetNexID方法是從WorkItem繼承的。
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;

            // Property originalItemId is a member of ChangeRequest, but not 
            // of WorkItem.
            //屬性originalItemId是ChangeRequest的成員，但不是WorkItem的成員。
            this.originalItemID = originalID;
        }
    }

}
