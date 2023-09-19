using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solid Principles : 
            // it is 4 Principles : that make code is protictive 
            // to make easy for developer to manipulate it

            #region Single Responsiblity (SRP)
            // the first principle is : Single Responsiblity Principle ( SRP )
            // كل كلاس يخدم غرض واحد ميبقاش فيها اكتر من غرض او داتا ملهاش علاقة بعض
            // it is the class shoud have one 
            // the most diffuclt and important thing is to determine the responsiblites of the class
            // تحديد مسولية الكلاس اصعب واهم حاجة 
            #endregion

            #region Open/Close Principle (OCP)
            // the second principle is : Open/Close Principle (OCP)
            // اذا كانت شغالة متلعبش في حاجة
            // بمعني لو عندك كلاس وعملت عليه كل حاجة لغاية ما خلصت كل الاختبارات والتجارب الممكنة
            // متعملش حاجة فيها تاني
            // طاب لو جه تعديل ليه يتعمل في كلاس بيورث منه مثلا 
            // لكن الكلاس طول ما اشتغل ما تفتحهوش تاني
            // and there are many design pattern help to do that { one of them is the inhertance } 
            #endregion


            // the thrid Principle is Liskov Substitution Principle (LSP)
            //

        }
    }
}
