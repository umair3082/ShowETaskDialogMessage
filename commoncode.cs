using DevComponents.DotNetBar;
#region customer Messagebox

        public TaskDialogInfo CreateTaskDialogInfo(string TitleText, string HeaderText, string Icon, string Content, eTaskDialogButton Btns, string colorofbackground, string footertext)

        {
            TaskDialogInfo info = new TaskDialogInfo(TitleText, (eTaskDialogIcon)Enum.Parse(typeof(eTaskDialogIcon), Icon),
                HeaderText, Content, Btns,
                (eTaskDialogBackgroundColor)Enum.Parse(typeof(eTaskDialogBackgroundColor), colorofbackground),
                null, null, null, footertext, null);
            return info;
        }
        public eTaskDialogButton GetTaskDialogButtons()
        {
            eTaskDialogButton button = eTaskDialogButton.Ok;


            //button |= eTaskDialogButton.Cancel;

            //button |= eTaskDialogButton.Yes;

            //button |= eTaskDialogButton.No;

            //button |= eTaskDialogButton.Retry;

            //button |= eTaskDialogButton.Close;

            //if (!checkBoxOk.Checked && button != eTaskDialogButton.Ok)
            //    button = button & ~(button & eTaskDialogButton.Ok);

            return button;
        }

        public void showcustomermsg(string TitleText, string HeaderText, string Icon, string Content, string colorofbackground, string footertext)
        {
            TaskDialogInfo info = CreateTaskDialogInfo(TitleText, HeaderText, Icon, Content, GetTaskDialogButtons(), colorofbackground, null);

            eTaskDialogResult result = TaskDialog.Show(info);
        }
        #endregion
