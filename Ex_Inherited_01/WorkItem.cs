using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Inherited_01
{
    //WorkItem 隱含從物件類繼承。
    public class WorkItem
    {
        //靜態欄位 currentID 存儲已創建的最後一個 WorkItem 的作業 ID。
        private static int currentID;


        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        // 預設建構函式,如果派生類未顯式調用基類建構函式，則調用預設建構函式
        public WorkItem()
        {
            ID = 0;
            Title = "Default title";
            Description = "Default description.";
            jobLength = new TimeSpan();
        }

        // Instance constructor that has three parameters.
        // 具有三個參數的實例構造函數
        public WorkItem(string title, string desc, TimeSpan joblen)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;
        }

        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of WorkItem or ChangeRequest is created, or currentID is referenced.
        /*用於初始化靜態成員currentID的靜態構造函數。
		 * 在創建WorkItem或ChangeRequest的任何實例或引用currentID之前，
		 * 自動一次調用此構造函數。
		 */
        static WorkItem()
        {
            currentID = 0;
        }

        protected int GetNextID()
        {
            // currentID is a static field. It is incremented each time a new
            // instance of WorkItem is created.
            /* currentID是一個靜態字段。
			 * 每次創建WorkItem的新實例時，它都會增加。
			 */
            return ++currentID;
        }

        // Method Update enables you to update the title and job length of an
        // existing WorkItem object.
        /* 使用“方法更新”可以更新現有WorkItem對象的標題和作業長度。*/
        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object.
        // 從System.Object繼承的ToString方法的虛擬方法重寫。
        public override string ToString()
        {
            return $"{this.ID} - {this.Title}";
        }
    }
}
 
 
 