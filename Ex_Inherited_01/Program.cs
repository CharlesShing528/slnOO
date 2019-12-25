using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Inherited_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of WorkItem by using the constructor in the 
            // base class that takes three arguments.
            // 通過使用具有三個參數的基類中的構造函數來創建WorkItem的實例。
            WorkItem item = new WorkItem("Fix Bugs",
                                         "Fix all bugs in my code branch",
                                         new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            // 通過使用帶有四個參數的派生類中的構造函數來創建ChangeRequest的實例。
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the 
            // ChangeRequest object.
            // 使用繼承的Update方法更改ChangeRequest對象的標題。
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            // ChangeRequest繼承了WorkItem對ToString的覆蓋。
            Console.WriteLine(change.ToString());

            // Keep the console open in debug mode.
            // 在ebug mode下保持控制台打開。
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
/* Output:
    1 - Fix Bugs
    2 - Change the Design of the Base Class
*/
