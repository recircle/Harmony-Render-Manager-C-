using System;
using System.Text;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Diagnostics;

namespace HarmonyRender
{
    public partial class Form1 : Form
    {

        private string harmonyPath = "C:\\Program Files (x86)\\Toon Boom Animation\\Toon Boom Harmony 20 Premium\\win64\\bin\\HarmonyPremium.exe";

        private string nodesExport = "all";
        private string xxtension = ".xstage";
        private string nameAppendix = "_render";
        private string modifiedFileSuffix = "_render.xstage";

        private string m_defaultOutputFolder = "";
        private int renderFileNum = 0;
        private bool renderAllFiles = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tBfilesBindingSource.Add(new TBfiles() { Name = "File1", ExportName = "K01", ExportPath = "File/File/File", Frames = 78 });
        }

        //add folder files button
        private void addDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = "Folder Selection.";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileArray = Directory.GetDirectories(@ofd.FileName.Replace(ofd.SafeFileName, "")).SelectMany(d => Directory.GetFiles(d, "*.xstage"));
                //string[] fileArray = Directory.GetFiles(@ofd.FileName.Replace(ofd.SafeFileName, ""), "*.xstage", SearchOption.AllDirectories); //malo sporiji
                foreach (String file in fileArray)
                {
                    if (System.IO.Path.GetFileNameWithoutExtension(file).Contains("_render"))
                        continue;

                    TBfiles TBfile = new TBfiles();
                    TBfile.Id = dataGridView.Rows.Count;
                    TBfile.Name = System.IO.Path.GetFileNameWithoutExtension(file);
                    TBfile.Path = System.IO.Path.GetDirectoryName(file) + "\\";
                    TBfile.Frames = int.Parse(getFileFrameNumber(System.IO.Path.GetFullPath(file)));

                    if (TBfile.Name.Contains("Song"))
                        TBfile.ExportName = "S" + TBfile.Name.Substring(TBfile.Name.Length - 2);
                    else
                        TBfile.ExportName = "K" + TBfile.Name.Substring(TBfile.Name.Length - 2);

                    if (!string.IsNullOrEmpty(m_defaultOutputFolder))
                        TBfile.ExportPath = m_defaultOutputFolder;

                    tBfilesBindingSource.Add(new TBfiles() { Name = TBfile.Name, ExportName = TBfile.ExportName, ExportPath = TBfile.ExportPath, Frames = TBfile.Frames, Path = TBfile.Path });

                    //Console.WriteLine("File: " + Path.GetFileName(file) + "   Path: " + Path.GetDirectoryName(file));
                    //Console.WriteLine(TBfile.Path);
                }
            }
        }

        //add file button
        private void addFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Browse Harmony Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xstage",
                Filter = "xstage files (*.xstage)|*.xstage",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TBfiles TBfile = new TBfiles();
                TBfile.Id = dataGridView.Rows.Count;
                TBfile.Name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                TBfile.Path = ofd.FileName.Replace(ofd.SafeFileName, "");
                TBfile.ExportName = "K" + TBfile.Name.Substring(TBfile.Name.Length - 2);
                TBfile.Frames = int.Parse(getFileFrameNumber(System.IO.Path.GetFullPath(ofd.FileName)));

                if (!string.IsNullOrEmpty(m_defaultOutputFolder))
                    TBfile.ExportPath = m_defaultOutputFolder;

                tBfilesBindingSource.Add(new TBfiles() { Name = TBfile.Name, ExportName = TBfile.ExportName, ExportPath = TBfile.ExportPath, Frames = TBfile.Frames, Path = TBfile.Path });

                //Console.WriteLine("File path: " + System.IO.Path.GetFullPath(ofd.FileName) + " Path: " + TBfile.Path);
                //Console.WriteLine(TBfile.Path);
            }
        }

        // render and remove cell buttons
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            if (dataGridView.Columns[e.ColumnIndex].Name == "Remove")
            {
                if (MessageBox.Show("Remove " + row.Cells[1].Value.ToString() + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tBfilesBindingSource.RemoveCurrent();
                }
                    
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "Render")
            {
                if (MessageBox.Show("Render " + row.Cells[1].Value.ToString() + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    renderAllFiles = false;

                    TBfiles file = row.DataBoundItem as TBfiles;
                    parseAndSaveXMLfile(file);
                }
            }
        }

        // select folder button
        private void buttBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = "Folder Selection.";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                m_defaultOutputFolder = ofd.FileName.Replace(ofd.SafeFileName, "");
                defaultOutputFolder.Text = m_defaultOutputFolder;
            }

            
        }

        private void defaultOutputFolder_TextChanged(object sender, EventArgs e)
        {

        }

        //render all files button
        private void renderAll_Click(object sender, EventArgs e)
        {
            if (!renderAllFiles)
            {
                renderAllFiles = true;
                renderAll();
            };
        }

        private void renderAll()
        {
            DataGridViewRow row = dataGridView.Rows[renderFileNum];
            TBfiles file = row.DataBoundItem as TBfiles;

            parseAndSaveXMLfile(file);

            Console.WriteLine("Render file: " + file.ExportName);
            Console.WriteLine("Render all files: " + tBfilesBindingSource.Count);
        }

        //RENDER
        public static string getFileFrameNumber(string filePath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filePath);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(document.NameTable);

            var scene = document.SelectSingleNode("//scenes/scene[@name='Top']", nsmgr);
            var frameNumber = scene.Attributes["nbframes"]?.Value;

            //Console.WriteLine("Frame number: " + frameNumber);

            return frameNumber;
        }

        void parseAndSaveXMLfile(TBfiles file)
        {
            var newFileName = file.Path + file.Name + "_render.xstage";

            try
            {
                XDocument document = XDocument.Load(file.Path + file.Name + ".xstage");
                document.XPathSelectElement("//scenes/scene[@name = 'Top']//module[@name = 'Write']/attrs").Remove();
                
                var writeNode = document.XPathSelectElement("//scenes/scene[@name = 'Top']//module[@name = 'Write']");

                var rendName = file.ExportPath + file.ExportName;
                writeNode.Add(exporVideoSettings(rendName));

                FileStream fs = File.OpenWrite(newFileName);
                document.Save(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Modifying harmony file failed - " + file.Name);
            }

            Console.WriteLine("Exported file: " + newFileName);

            if (File.Exists(newFileName))
            {
                string folder = Directory.GetCurrentDirectory();
                var executedOk = ExecuteCommandWithFile(folder, newFileName, file);

                if (executedOk)
                {
                    
                    Console.WriteLine("Done rendering");

                    if(renderAllFiles)
                    {
                        renderFileNum += 1;
                        if (renderFileNum <= tBfilesBindingSource.Count - 1)
                        {
                            renderAll();
                            Console.WriteLine("Render next animation: " + renderFileNum);
                        }
                        else
                        {
                            renderFileNum = 0;
                            renderAllFiles = false;
                            Console.WriteLine("Done rendering all files");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Still working");
                }
            }
            else
            {
                Console.WriteLine("File not ready for rendering!");
            }

            //var comand = @"""""" + harmonyPath + @""" -user usabatch -batch " + @"""" + newFileName + @"""""";
            //var comand = $" \"{ harmonyPath}\" -user usabatch -batch \"{newFileName}\"";
            //ExecuteCommand(comand);
        }

        XElement exporVideoSettings(string movieName)
        {
            var xmlTree = new XElement("attrs",
                new XElement("exportToMovie", new XAttribute("val", "true")),
                new XElement("drawingName", new XAttribute("val", "frames/final-")),
                new XElement("moviePath", new XAttribute("val", movieName)),
                new XElement("movieFormat", new XAttribute("val", "com.toonboom.quicktime.legacy")),
                new XElement("movieAudio"),
                new XElement("movieVideo"),
                new XElement("movieVideoaudio", new XAttribute("val", "Enable Sound(false)Enable Video(true)QT(000000000000000000000000000004297365616E0000000100000005000000000000022F76696465000000010000001200000000000000227370746C000000010000000000000000706E672000000000002000000200000000207470726C000000010000000000000000000000000000000000000000000000246472617400000001000000000000000000000000000000000000000000000000000000156D70736F00000001000000000000000000000000186D66726100000001000000000000000000000000000000187073667200000001000000000000000000000000000000156266726100000001000000000000000000000000166D70657300000001000000000000000000000000002868617264000000010000000000000000000000000000000000000000000000000000000000000016656E647300000001000000000000000000000000001663666C67000000010000000000000000004400000018636D66720000000100000000000000006170706C00000014636C75740000000100000000000000000000006463646563000000010000000000000000000000000000000000000000000000447365616E00000001000000020000000000000018696C61630000000100000000000000000000000000000018706E676600000001000000000000000062666C740000001C766572730000000100000000000000000003001C000100000000001574726E630000000100000000000000000000000018776474680000000100000000000000000F000000000000186865677400000001000000000000000008700000000001066973697A000000010000000900000000000000186977647400000001000000000000000000000F0000000018696867740000000100000000000000000000087000000018707764740000000100000000000000000000000000000018706867740000000100000000000000000000000000000034636C617000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000001C706173700000000100000000000000000000000000000000000000187363616D000000010000000000000000000000000000001564696E74000000010000000000000000000000001575656E66000000010000000000000000000000008C736F756E0000000100000005000000000000001873736374000000010000000000000000736F777400000018737372740000000100000000000000005622000000000016737373730000000100000000000000000010000000167373636300000001000000000000000000010000001C76657273000000010000000000000000000300140001000000000015656E7669000000010000000000000000010000003F7361766500000001000000020000000000000015666173740000000100000000000000000000000016737374790000000100000000000000000001)")),
                new XElement("leadingZeros", new XAttribute("val", "3")),
                new XElement("start", new XAttribute("val", "1")),
                new XElement("drawingType", new XAttribute("val", "TGA")),

                new XElement("enabling",
                    new XElement("filter", new XAttribute("val", "ALWAYS")),
                    new XElement("filterName"),
                    new XElement("filterResX", new XAttribute("val", "720")),
                    new XElement("filterResY", new XAttribute("val", "540"))
                ),

                new XElement("compositePartitioning", new XAttribute("val", "NoCompositePartitioning")),
                new XElement("zPartitionRange", new XAttribute("val", "1"), new XAttribute("defaultValue", "1")),
                new XElement("cleanUpPartitionFolders", new XAttribute("val", "true"))
            );

            return xmlTree;
        }

        public bool ExecuteCommandWithFile(string folder, string filePath, TBfiles file)
        {
            var processInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                FileName = harmonyPath,
                Arguments = $" -user usabatch -batch {filePath}",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = folder
            };

            Process myProcess = new Process()
            {
                StartInfo = processInfo
            };

            myProcess.OutputDataReceived += new DataReceivedEventHandler((sender, e) => { Console.WriteLine(e.Data); });
            myProcess.ErrorDataReceived += new DataReceivedEventHandler((sender, e) => 
            {
                var name = "Rendered frame ";
                if (e.Data != null)
                {
                    if (e.Data.Contains(name))
                    {
                        var num = int.Parse(e.Data.Substring(e.Data.LastIndexOf(' ') + 1));
                        Console.WriteLine(num);

                        //rederingTextOutput.Text = "RENDERING / file " + file.Name + " frame: " + num;

                        //if (num == file.Frames)
                        //{
                        //    Console.WriteLine("RENDER COMPLETE!!!");
                        //}
                    }
                }

                //Console.WriteLine(e.Data);
            });
            
            myProcess.Start();
            myProcess.BeginErrorReadLine();

            while (!myProcess.StandardOutput.EndOfStream)
            {
                Console.WriteLine("Render in progress: " + myProcess.StandardOutput.ReadLine());
            }
            myProcess.WaitForExit();
            return myProcess.ExitCode == 0;
        }

        static void ExecuteCommand(string command)
        {
            Console.WriteLine("Render file: > " + command);

            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }

        private void rederingTextOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
