namespace Main
{
    public static class ThreadHelperClass
    {
        delegate void SetEnableCallback(Form f, Control ctrl, bool isEnable);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetEnable(Form form, Control ctrl, bool isEnable)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetEnableCallback d = new SetEnableCallback(SetEnable);
                form.Invoke(d, new object[] { form, ctrl, isEnable });
            }
            else
            {
                ctrl.Enabled = isEnable;
            }
        }


        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }


        delegate void SetVisibleCallback(Form f, Control ctrl, bool visible);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetVisible(Form form, Control ctrl, bool visible)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetVisibleCallback d = new SetVisibleCallback(SetVisible);
                form.Invoke(d, new object[] { form, ctrl, visible });
            }
            else
            {
                ctrl.Visible = visible;
            }
        }





        delegate void SetFocusCallback(Form f, Control ctrl);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetFocus(Form form, Control ctrl)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetFocusCallback d = new SetFocusCallback(SetFocus);
                form.Invoke(d, new object[] { form, ctrl });
            }
            else
            {
                ctrl.Focus();
            }
        }



        delegate void AppendTextareaCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetAppendTextarea(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                AppendTextareaCallback d = new AppendTextareaCallback(SetAppendTextarea);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text += text;
            }
        }
    }

}
