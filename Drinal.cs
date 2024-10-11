using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO.Compression;

[assembly: AssemblyTitle("Drinal Curse Plugin")]
[assembly: AssemblyDescription("Track the Drinal avatar curse cure timing")]
[assembly: AssemblyCompany("Mineeme")]
[assembly: AssemblyVersion("1.0.0.0")]

namespace ACT_Drinal
{
    public class Drinal : UserControl, IActPluginV1
	{
		#region Designer Created Code (Avoid editing)
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReset1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStart1 = new System.Windows.Forms.TextBox();
            this.numericUpDownAlert = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlert1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regular Expression that resets the timer:";
            // 
            // textBoxReset1
            // 
            this.textBoxReset1.Location = new System.Drawing.Point(6, 69);
            this.textBoxReset1.Name = "textBoxReset1";
            this.textBoxReset1.Size = new System.Drawing.Size(431, 20);
            this.textBoxReset1.TabIndex = 1;
            this.textBoxReset1.TextChanged += new System.EventHandler(this.textBoxReset1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zone";
            // 
            // textBoxZone1
            // 
            this.textBoxZone1.Location = new System.Drawing.Point(6, 16);
            this.textBoxZone1.Name = "textBoxZone1";
            this.textBoxZone1.Size = new System.Drawing.Size(431, 20);
            this.textBoxZone1.TabIndex = 3;
            this.textBoxZone1.TextChanged += new System.EventHandler(this.textBoxZone1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regular Expression that starts the timer:";
            // 
            // textBoxStart1
            // 
            this.textBoxStart1.Location = new System.Drawing.Point(6, 123);
            this.textBoxStart1.Name = "textBoxStart1";
            this.textBoxStart1.Size = new System.Drawing.Size(431, 20);
            this.textBoxStart1.TabIndex = 5;
            this.textBoxStart1.TextChanged += new System.EventHandler(this.textBoxStart1_TextChanged);
            // 
            // numericUpDownAlert
            // 
            this.numericUpDownAlert.Location = new System.Drawing.Point(6, 175);
            this.numericUpDownAlert.Name = "numericUpDownAlert";
            this.numericUpDownAlert.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownAlert.TabIndex = 6;
            this.numericUpDownAlert.ValueChanged += new System.EventHandler(this.numericUpDownAlert_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seconds til alert:";
            // 
            // textBoxAlert1
            // 
            this.textBoxAlert1.Location = new System.Drawing.Point(99, 174);
            this.textBoxAlert1.Name = "textBoxAlert1";
            this.textBoxAlert1.Size = new System.Drawing.Size(338, 20);
            this.textBoxAlert1.TabIndex = 8;
            this.textBoxAlert1.TextChanged += new System.EventHandler(this.textBoxAlert1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alert:";
            // 
            // Drinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAlert1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownAlert);
            this.Controls.Add(this.textBoxStart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZone1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReset1);
            this.Controls.Add(this.label1);
            this.Name = "Drinal";
            this.Size = new System.Drawing.Size(686, 384);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox textBoxReset1;
        private Label label2;
        private TextBox textBoxZone1;
        private Label label3;
        private TextBox textBoxStart1;
        private NumericUpDown numericUpDownAlert;
        private Label label4;
        private TextBox textBoxAlert1;
        private Label label5;
        private System.Windows.Forms.Label label1;
		
		#endregion
		public Drinal()
		{
			InitializeComponent();
		}

		Label lblStatus;	// The status label that appears in ACT's Plugin tab
		string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\Drinal.config.xml");
		SettingsSerializer xmlSettings;
        string zone1 = null;
        Regex start1 = null;
        Regex reset1 = null;
        Match matchStart = null;
        string alert1 = null;
        string timerName = "Drinal Curse";
        string timerCategory = "Drinal";
        string cureWho = "curse";
        enum eStates { Idle, Reset, Started }
        eStates state = eStates.Idle;
        System.Timers.Timer timer1 = new System.Timers.Timer();
        string githubProject = "ACT_Drinal";
        string githubOwner = "jeffjl74";

		#region IActPluginV1 Members
		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{
			lblStatus = pluginStatusText;	// Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);	// Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill;	// Expand the UserControl to fill the tab's client space
			xmlSettings = new SettingsSerializer(this);	// Create a new settings serializer and pass it this instance
			LoadSettings();

            //defaults for first time start
            if (zone1 == null)
                textBoxZone1.Text = "Celebration Avatar Challenge: \\#00FF00Drinal\\/c [Raid]";
            if (start1 == null)
                textBoxStart1.Text = "Drinal's Power Over Death hits (?<victim>\\w+)";
            if(reset1 == null)
                textBoxReset1.Text = "#00FF00\"Power Over Death\" has been successfully removed from (\\w+)";
            if (alert1 == null)
                textBoxAlert1.Text = "cure ${victim}";
            if (timer1.Interval == 100)
                numericUpDownAlert.Value = 17;

            timer1.SynchronizingObject = ActGlobals.oFormActMain;
            timer1.Elapsed += Timer1_Elapsed;

            // Create some sort of parsing event handler.  After the "+=" hit TAB twice and the code will be generated for you.
            ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;

            if (ActGlobals.oFormActMain.GetAutomaticUpdatesAllowed())
            {
                // If ACT is set to automatically check for updates, check for updates to the plugin
                // If we don't put this on a separate thread, web latency will delay the plugin init phase
                new Thread(new ThreadStart(oFormActMain_UpdateCheckClicked)).Start();
            }

            lblStatus.Text = "Plugin Started";
		}

        public void DeInitPlugin()
		{
            // Unsubscribe from any events you listen to when exiting!
            ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;

            SaveSettings();
			lblStatus.Text = "Plugin Exited";
		}


        #endregion

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();
            if (matchStart != null)
            {
                string alert = alert1;
                string[] groups = start1.GetGroupNames();
                //group 0 is always the whole line
                if (groups.Length > 1)
                {
                    for (int i = 1; i < groups.Length; i++)
                    {
                        int cap;
                        bool result = int.TryParse(groups[i], out cap);
                        if (result)
                            alert = alert1.Replace("$" + groups[i], cureWho);
                        else
                            alert = alert1.Replace("${" + groups[i] + "}", cureWho);
                    }
                }
                ActGlobals.oFormActMain.TTS(alert);
                //Debug.WriteLine(alert);
            }
        }
        private void BuildSpellTimer()
        {
            int spellTime = (int)numericUpDownAlert.Value;
            Color color = Color.Gold;
            int warningTime = 7;
            string warning = string.Empty;
            TimerData td1 = new TimerData(timerName, true, spellTime, false, false, "", warning, warningTime, false, false, zone1, color, true, false);
            td1.Category = timerCategory;
            td1.RemoveValue = 0;
            if (spellTime != 0)
            {
                ActGlobals.oFormSpellTimers.AddEditTimerDef(td1);
                ActGlobals.oFormSpellTimers.RebuildSpellTreeView();

                //ActGlobals.oFormSpellTimers.SearchSpellTreeView(timerName);
                //ActGlobals.oFormSpellTimers.Visible = true;
            }
        }

        private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            if (ActGlobals.oFormActMain.CurrentZone == zone1)
            {
                Match match = reset1.Match(logInfo.logLine);
                if (match.Success)
                {
                    state = eStates.Idle;
                    timer1.Stop();
                    timer1.Interval = timer1.Interval;
                    //if(match.Groups.Count > 1)
                    //    Debug.WriteLine(match.Groups[1].Value.ToString() + " cured");
                }
                else if(state == eStates.Idle)
                {
                    match = start1.Match(logInfo.logLine);
                    if (match.Success)
                    {
                        matchStart = match;
                        state = eStates.Started;
                        timer1.Stop();
                        timer1.Interval = timer1.Interval;
                        timer1.Start();
                        if(matchStart.Groups.Count > 1)
                            cureWho = matchStart.Groups[1].Value.ToString();
                        ActGlobals.oFormSpellTimers.NotifySpell(timerCategory, timerName, false, cureWho, true);
                        //Debug.WriteLine("Starting timer for " + cureWho);
                    }
                }
            }
        }

        void oFormActMain_UpdateCheckClicked()
        {
            try
            {
                Version localVersion = this.GetType().Assembly.GetName().Version;
                Task<Version> vtask = Task.Run(() => { return GetRemoteVersionAsync(); });
                vtask.Wait();
                Version remoteVersion = vtask.Result;
                string Lver = string.Format("{0}.{1}.{2}",localVersion.Major,localVersion.Minor,localVersion.Build);
                string Rver = string.Format("{0}.{1}.{2}", remoteVersion.Major, remoteVersion.Minor, remoteVersion.Build);
                if (remoteVersion > localVersion)
                {
                    //Rectangle screen = Screen.GetWorkingArea(ActGlobals.oFormActMain);
                    DialogResult result = MessageBox.Show(
                          @"There is an update for Drinal Curse. "
                        + @"Update it now?"
                        , "Trigger Tree New Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Task<FileInfo> ftask = Task.Run(() => { return GetRemoteFileAsync(); });
                        ftask.Wait();
                        if (ftask.Result != null)
                        {
                            //FileInfo updatedFile = ActGlobals.oFormActMain.PluginDownload(pluginId);
                            FileInfo updatedFile = ftask.Result as FileInfo;
                            ActPluginData pluginData = ActGlobals.oFormActMain.PluginGetSelfData(this);
                            pluginData.pluginFile.Delete();
                            updatedFile.MoveTo(pluginData.pluginFile.FullName);
                            Application.DoEvents();
                            ThreadInvokes.CheckboxSetChecked(ActGlobals.oFormActMain, pluginData.cbEnabled, false);
                            Application.DoEvents();
                            ThreadInvokes.CheckboxSetChecked(ActGlobals.oFormActMain, pluginData.cbEnabled, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Drinal Curse Plugin Update Download error: " + ex.Message);
            }
        }

        private async Task<Version> GetRemoteVersionAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    ProductInfoHeaderValue hdr = new ProductInfoHeaderValue(githubProject, "1");
                    client.DefaultRequestHeaders.UserAgent.Add(hdr);
                    string url = string.Format("https://api.github.com/repos/{0}/{1}/releases/latest", githubOwner, githubProject);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Regex reVer = new Regex(@"""tag_name.:.v(\d+)\.(\d+)\.(\d+)(\.(\d+))?""");
                        Match match = reVer.Match(responseBody);
                        if (match.Success)
                        {
                            int major = Int32.Parse(match.Groups[1].Value);
                            int minor = Int32.Parse(match.Groups[2].Value);
                            int build = Int32.Parse(match.Groups[3].Value);
                            if (string.IsNullOrEmpty(match.Groups[5].Value))
                                return new Version(major, minor, build, 0);
                            else
                            {
                                int revision = Int32.Parse(match.Groups[5].Value);
                                return new Version(major, minor, build, revision);
                            }
                        }
                    }
                    return new Version("0.0.0.0");
                }
            }
            catch { return new Version("0.0.0.0"); }
        }

        private async Task<FileInfo> GetRemoteFileAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    ProductInfoHeaderValue hdr = new ProductInfoHeaderValue(githubProject, "1");
                    client.DefaultRequestHeaders.UserAgent.Add(hdr);
                    string dl = string.Format("https://github.com/{0}/{1}/releases/latest/download/{2}.cs", githubOwner, githubProject, githubProject);
                    HttpResponseMessage response = await client.GetAsync(dl);
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] responseBody = await response.Content.ReadAsByteArrayAsync();
                        string tmp = Path.GetTempFileName();
                        File.WriteAllBytes(tmp, responseBody);
                        FileInfo fi = new FileInfo(tmp);
                        return fi;
                    }
                }
                return null;
            }
            catch { return null; }
        }

        void LoadSettings()
		{
			xmlSettings.AddControlSetting(textBoxZone1.Name, textBoxZone1);
			xmlSettings.AddControlSetting(textBoxReset1.Name, textBoxReset1);
            xmlSettings.AddControlSetting(textBoxStart1.Name, textBoxStart1);
            xmlSettings.AddControlSetting(textBoxAlert1.Name, textBoxAlert1);
            xmlSettings.AddControlSetting(numericUpDownAlert.Name, numericUpDownAlert);

            if (File.Exists(settingsFile))
			{
				FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				XmlTextReader xReader = new XmlTextReader(fs);

				try
				{
					while (xReader.Read())
					{
						if (xReader.NodeType == XmlNodeType.Element)
						{
							if (xReader.LocalName == "SettingsSerializer")
							{
								xmlSettings.ImportFromXml(xReader);
							}
						}
					}
				}
				catch (Exception ex)
				{
					lblStatus.Text = "Error loading settings: " + ex.Message;
				}
				xReader.Close();
			}
		}
		void SaveSettings()
		{
			FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
			XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
			xWriter.Formatting = Formatting.Indented;
			xWriter.Indentation = 1;
			xWriter.IndentChar = '\t';
			xWriter.WriteStartDocument(true);
			xWriter.WriteStartElement("Config");	// <Config>
			xWriter.WriteStartElement("SettingsSerializer");	// <Config><SettingsSerializer>
			xmlSettings.ExportToXml(xWriter);	// Fill the SettingsSerializer XML
			xWriter.WriteEndElement();	// </SettingsSerializer>
			xWriter.WriteEndElement();	// </Config>
			xWriter.WriteEndDocument();	// Tie up loose ends (shouldn't be any)
			xWriter.Flush();	// Flush the file buffer to disk
			xWriter.Close();
		}

        private void textBoxZone1_TextChanged(object sender, EventArgs e)
        {
            zone1 = textBoxZone1.Text;
        }

        private void textBoxReset1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                reset1 = new Regex(textBoxReset1.Text, RegexOptions.Compiled);
                textBoxReset1.ForeColor = Color.Black;
            }
            catch 
            {
                textBoxReset1.ForeColor = Color.Red;
            }
        }

        private void textBoxStart1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                start1 = new Regex(textBoxStart1.Text, RegexOptions.Compiled);
                textBoxStart1.ForeColor = Color.Black;
            }
            catch
            {
                textBoxStart1.ForeColor = Color.Red;
            }
        }

        private void numericUpDownAlert_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDownAlert.Value * 1000;
            timer1.Enabled = true;
            BuildSpellTimer();
        }

        private void textBoxAlert1_TextChanged(object sender, EventArgs e)
        {
            alert1 = textBoxAlert1.Text;
        }
    }
}
