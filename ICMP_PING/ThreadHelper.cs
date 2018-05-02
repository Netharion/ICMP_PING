using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace ICMP_PING
{
    public static class ThreadHelper
    {
        delegate void SetTextCallback(Form1 f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        /// 

        delegate void SetValueCallBack(Form1 f, Control ctrl, int value);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        /// 

        delegate void SetListItemCallBack(Form1 f, ListView ctrl, ListViewItem list);
        delegate void UpdateProgressBarCallBack(Form1 f, ToolStripProgressBar ctrl, int value);
        delegate void SetGmapCallBack(Form1 f, GMapControl ctrl, int value);


        public static void SetText(Form1 form, Control ctrl, string text)
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

        public static void SetList(Form1 form, ListView ctrl, ListViewItem listItem)
        {
            if (ctrl.InvokeRequired)
            {
                SetListItemCallBack d = new SetListItemCallBack(SetList);
                form.Invoke(d, new object[] { form, ctrl, listItem });
            }
            else
            {
                ctrl.Items.Add(listItem);    
                ctrl.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ctrl.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }

        }
        public static void SetListClear(Form1 form, ListView ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                SetListItemCallBack d = new SetListItemCallBack(SetList);
                form.Invoke(d, new object[] { form, ctrl});
            }
            else
            {
                ctrl.Items.Clear();
            }

        }
        public static void UpdateProgressBar(Form1 form, ToolStripProgressBar ctrl, int value)
        {
            if (ctrl.GetCurrentParent().InvokeRequired)
            {
                UpdateProgressBarCallBack d = new UpdateProgressBarCallBack(UpdateProgressBar);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                try
                {
                    ctrl.Value = value;
                }
                catch
                {
                    Console.WriteLine(value);
                    ctrl.Value = ctrl.Maximum;
                }
                
            }

        }
        public static void UpdateProgressBarMinimum(Form1 form, ToolStripProgressBar ctrl, int value)
        {
            if (ctrl.GetCurrentParent().InvokeRequired)
            {
                UpdateProgressBarCallBack d = new UpdateProgressBarCallBack(UpdateProgressBarMinimum);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Minimum = value;
            }
        }
        public static void UpdateProgressBarMaximum(Form1 form, ToolStripProgressBar ctrl, int value)
        {
            if (ctrl.GetCurrentParent().InvokeRequired)
            {
                UpdateProgressBarCallBack d = new UpdateProgressBarCallBack(UpdateProgressBarMaximum);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Maximum = value;
            }
        }
        public static void SetGmapZoom(Form1 form, GMapControl ctrl, int value)
        {
            if (ctrl.InvokeRequired)
            {
                SetGmapCallBack d = new SetGmapCallBack(SetGmapZoom);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Zoom = value;

            }

        }




    }
}     
        

    

