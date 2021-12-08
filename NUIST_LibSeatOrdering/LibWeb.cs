using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using MetroFramework;

namespace NUIST_LibSeatOrdering
{
    public partial class LibWeb : MetroFramework.Forms.MetroForm
    {
        GeckoWebBrowser browser;
        public LibWeb()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Xpcom.Initialize("Firefox");
            browser = new GeckoWebBrowser();
            this.browser.Name = "browser";
            GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;//设置偏好：字体
            GeckoPreferences.User["privacy.donottrackheader.enabled"] = true;//设置浏览器不被追踪
            GeckoPreferences.User["intl.accept_languages"] = "zh-CN,zh;q=0.9,en;q=0.8";//不设置的话默认是英文区
            //GeckoPreferences.User["permissions.default.image"] = 2; //  block  image  禁止加载图片
            //GeckoPreferences.User["plugin.state.flash"] = 0;  // bloack flash禁止加载flash
            browser.CreateControl();
            browser.NoDefaultContextMenu = true; //禁用右键菜单
            browser.Dock = DockStyle.Fill;
            panel1.Controls.Add(browser);
            browser.ProgressChanged += Gecko_ProgressChanged;
            browser.CreateWindow += Gecko_CreateWindow;//打开新窗口事件，全部设为在同一窗口打开
            browser.DocumentCompleted += Gecko_DocumentCompleted;
            //browser.UseHttpActivityObserver = true;//开启拦截请求
            //browser.ObserveHttpModifyRequest += Browser_ObserveHttpModifyRequest;//拦截请求（在创建窗口之前就拦截。）  同时取消创建创建，在主窗口打开
            browser.Navigate("https://lib.nuist.edu.cn/");
            //browser.Navigate("http://127.0.0.1:8848/Html/login/login.html");
            //browser.Navigate("https://www.bilibili.com/");
        }
        private void Gecko_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);  //先获取到jquery对象
            executor.ExecuteJQuery("$('#a')");    //然后执行jquery的代码
            using (AutoJSContext context = new AutoJSContext(browser.Window))
            {
                string result;
                context.EvaluateScript("3 + 2;", out result);
                context.EvaluateScript("'hello' + ' ' + 'world';", out result);
            }
            progressBar1.Value = 0;
        }
        //当前窗口跳转网址
        private void Gecko_CreateWindow(object sender, GeckoCreateWindowEventArgs e)
        {
            try
            {
                browser.Navigate(e.Uri);
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //e.InitialHeight = 500;
            //e.InitialWidth = 500;
        }
        private void Gecko_ProgressChanged(object sender, GeckoProgressEventArgs e)
        {
            if (e.MaximumProgress == 0)
                return;

            var value = (int)Math.Min(100, (e.CurrentProgress * 100) / e.MaximumProgress);
            if (value == 100)
                return;
            progressBar1.Value = value;
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void btn_GoPreview_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }
    }
}
