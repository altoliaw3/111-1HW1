/* 
 * Test頁面
 * @author Kuan-Teng, Liao
 * @details 在第一次載入頁面時，會先進入Page_Load事件內執行內部方法；\\
 * 當按下按鈕後，亦會先進入Page_Load事件後，再進入按鈕的事件，因此可以看出印出結果並不是單純的按鈕結果。
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW1 {
    public partial class Test : System.Web.UI.Page {
        /// <summary>
        /// 頁面載入
        /// </summary>
        /// <param name="sender">頁面中物件</param>
        /// <param name="e">參數</param>
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write("Hello App");
        }

        /// <summary>
        /// 按下btn_Show後除了需要執行Page_Load事件外，亦須執行該btn_Show_Click事件。
        /// 該事件亦會出現在.aspx頁面中該button物件中的OnClick事件中
        /// </summary>
        /// <param name="sender">頁面中物件</param>
        /// <param name="e">參數</param>
        protected void btn_Show_Click(object sender, EventArgs e) {
            Response.Write("Hello Button");            
        }
    }
}