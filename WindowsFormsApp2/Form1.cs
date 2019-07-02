using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using XML_Program;
using System.IO;
using ICSharpCode.AvalonEdit;
using System.Windows.Forms.Integration;
using ICSharpCode.AvalonEdit.Highlighting;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        private TextEditor textEditor_ = new TextEditor();
        private ElementHost host = new ElementHost();
        private TreeNode mySelectedNode1;
        private TreeNode mySelectedNode2;
        private DeviceContainer d = new DeviceContainer();
        private ArrayList a = new ArrayList();
        private SlotContainer s = new SlotContainer();
        private I2CBus I = new I2CBus();
        private string path_;
        private string nodename;
        private XmlDocument doc;
        private XmlNamespaceManager nsMgr;
        private XmlNode xmlnode;
        private CSharpCodeProvider codeProvider = new CSharpCodeProvider();
        private ICodeCompiler icc;
        private static string scripts_;
        private int compile_error=0;
        private string result_toassembly;
        public Form1()
        {
            InitializeComponent();
            GetXML_Header(Application.StartupPath+@"\DeviceServer.xml");
            Initial();
            getTreeview();
            DataGridView();
            Step_Parameter();
            
        }
        CompilerResults results;
        private void Code_Compiler(string script)
        {
            CodeDomProvider cd = CodeDomProvider.CreateProvider("C#");
            //icc = codeProvider.CreateCompiler();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.GenerateInMemory = false;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            parameters.OutputAssembly=Application.StartupPath+ @"\file.dll";
            parameters.IncludeDebugInformation = true;
           // parameters.OutputAssembly
            //   parameters.ReferencedAssemblies.Add()
            results = cd.CompileAssemblyFromSource(parameters, script);
            compile_error = results.Errors.Count;
            //result_toassembly = results.PathToAssembly;

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError comperr in results.Errors)
                {
                    richTextBox2.AppendText("Line number: " + comperr.Line + " Error Text: "+comperr.ErrorText +"\n");
                }
            }
            //return results.CompiledAssembly;
            foreach(Type atype in results.CompiledAssembly.GetTypes())
            {
                //object[] method_p = new object[]
                //{
                //    "Okok"
                //};
               // MethodInfo method = atype.GetMethod("Main");
               // DialogResult method_result = (DialogResult)method.Invoke(null, method_p);
               // MessageBox.Show(method_result.ToString());
            }
        }
        private void Initial()
        {
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            treeView1.Scrollable = true;
            ToolWinBN.Enabled = true;
            StepEditorBN.Enabled = true;
            MegaViewBN.Enabled = true;
            DeviceServerBN.Enabled = true;
            LoginBN.Enabled = true;
            LogoutBN.Enabled = true;
        }
        private void Step_Parameter()
        {
            string c = Application.StartupPath + @"\Test.xml";
            textEditor_.ShowLineNumbers = true;
            textEditor_.Load(c);
            textEditor_.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");

            host.Size = new Size(2000, 1000);
            host.Location = new Point(0, 0);
            host.Child = textEditor_;
            this.richTextBox3.Controls.Add(host);
            textEditor_.MouseDoubleClick += text_editor_DoubleClick;
            textEditor_.KeyDown += TextEditor__KeyDown;
          
        }

        private DataTable Getdata_as_tree()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteConnection cn = new SQLiteConnection("data source=Scape.db");
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "Select * from T_Programs";
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cn.Close();
            return table;
        }
        private DataTable GetGridData()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteConnection cn = new SQLiteConnection("data source=Scape.db");
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "Select  TESTSTEP as 'Step Number', DESCRIPTION as 'Description', ACTIVE as 'Active' ," +
                "MESSDAT as 'Messdat',REF_Script, ModificationDate from T_ExecutionUnit ORDER BY RANDOM() limit 20";
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cn.Close();
            return table;
        }
        DataTable Grid_data;
        private void DataGridView()
        {
            Grid_data = GetGridData();
            dataGridView1.DataSource = Grid_data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void getTreeview()
        {
            DataTable dt = Getdata_as_tree();
            this.treeView2.Nodes.Clear();
            int[] Base = new int[dt.Rows.Count];
            int[] derived = new int[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode Parentnode = new TreeNode();
                string parent = dt.Rows[i][1].ToString();
                string child = dt.Rows[i][2].ToString();
                Parentnode.Text = parent;
                treeView2.Nodes.Add(Parentnode);
                treeView2.Nodes[i].Nodes.Add(child);
            }
        }

        public void GetXML_Header(object path)
        {
            doc = new XmlDocument();
            nsMgr = new XmlNamespaceManager(doc.NameTable);
            nsMgr.AddNamespace("a1", "http://schemas.microsoft.com/clr/nsassem/MhDeviceContainer/MhDeviceContainer%2C%20Version%3D4.4.28.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3D46c76a398fbe113e");
            nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            nsMgr.AddNamespace("clr", "http://schemas.microsoft.com/soap/encoding/clr/1.0");
            nsMgr.AddNamespace("encodingStyle", "http://schemas.xmlsoap.org/soap/encoding/");
            nsMgr.AddNamespace("SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
            nsMgr.AddNamespace("SOAP-ENC", "http://schemas.xmlsoap.org/soap/envelope/");
            nsMgr.AddNamespace("a2", "http://schemas.microsoft.com/clr/ns/System.Collections");
            nsMgr.AddNamespace("x", "adobe:ns:meta/");
            nsMgr.AddNamespace("xmptk", "adobe:ns:meta/");
            doc.Load(path.ToString());
            string rootName = doc.SelectSingleNode("/*").Name;
            nodename = rootName;
            xmlnode = doc.SelectSingleNode(nodename, nsMgr);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode("Device Server"));
            TreeNode tNode;
            tNode = treeView1.Nodes[0];
            AddNode(xmlnode, tNode);
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode != null)
                if (inXmlNode.HasChildNodes)
                {
                    nodeList = inXmlNode.ChildNodes;
                    foreach (XmlNode NX in nodeList)
                    {
                        inTreeNode.Nodes.Add(new TreeNode(NX.Name));
                        tNode = inTreeNode.Nodes[i];
                        AddNode(NX, tNode);
                        i++;
                    }
                }
                else
                {
                    inTreeNode.Text = inXmlNode.InnerText.ToString();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            treeView1.LabelEdit = true;
        }

        private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            richTextBox1.Clear();
            mySelectedNode1 = treeView1.GetNodeAt(e.X, e.Y);
            mySelectedNode2 = treeView2.GetNodeAt(e.X, e.Y);
            DataGridView();
            try
            {
                if (mySelectedNode1.Text != "SOAP-ENV:Envelope" && mySelectedNode1.Text !=
                    "SOAP-ENV:Body" && mySelectedNode1.Text != "Device Server")
                {
                    XmlNode XMLDoc = doc.SelectSingleNode(nodename, nsMgr);
                    XmlNodeList NodeLists = XMLDoc.ChildNodes;

                    foreach (XmlNode XNB in NodeLists)
                    {
                        if (XNB.Name == mySelectedNode1.Text)
                        {
                            XmlNodeList XLB = XNB.ChildNodes;
                            string xnls = XNB.Name;
                            switch (xnls)
                            {
                                case "a1:DeviceContainer":
                                    propertyGrid1.SelectedObject = d;
                                    break;

                                case "a2:ArrayList":
                                    propertyGrid1.SelectedObject = a;
                                    break;

                                case "a6:SlotContainer":
                                    propertyGrid1.SelectedObject = s;
                                    break;

                                case "a7:I2CBus":
                                    propertyGrid1.SelectedObject = I;
                                    break;
                            }
                            foreach (XmlNode XNA in XLB)
                            {
                                richTextBox1.AppendText(XNA.Name + " : " + XNA.InnerText.ToString() + "\n");
                            }
                        }
                    }
                }
            }
            catch { }

            if (e.Button == MouseButtons.Right)
            {
                Point clickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView1.GetNodeAt(clickPoint);
                if (mySelectedNode1 != null)
                {
                    mySelectedNode1.ContextMenuStrip = contextMenuStrip1;

                    treeView1.SelectedNode = CurrentNode;
                    Console.WriteLine("");
                }
            }
         
        }

        private void treeView1_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(false);
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label.\n" +
                           "The invalid characters are: '@','.', ',', '!'",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mySelectedNode1 != null && mySelectedNode1.Parent != null)
            {
                treeView1.SelectedNode = mySelectedNode1;
                treeView1.LabelEdit = true;
                if (!mySelectedNode1.IsEditing)
                {
                    mySelectedNode1.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("No tree node selected or selected node is a root node.\n" +
                   "Editing of root nodes is not allowed.", "Invalid selection");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (XmlNode v in xmlnode.ChildNodes)
            {
                richTextBox1.AppendText(v.Name + "\n");
                foreach (XmlNode Node in v)
                {
                    if (Node.InnerText.ToString() != "")
                        richTextBox1.AppendText("Key: " + Node.Name + " Value:" + Node.InnerText.ToString() + "\n");
                }
                richTextBox1.AppendText("\n");
            }
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "xml file (*.*)| *.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path_ = dialog.FileName;
                GetXML_Header(path_);
            }
        }

        private void StepEditorBN_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void DeviceServerBN_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string path = Application.StartupPath+@"\Test.xml";
            Stream xshd_stream = File.Create(path);
            textEditor_.Save(xshd_stream);

            int step_index = e.RowIndex;
            string step= Grid_data.Rows[step_index][4].ToString();
            DataTable Script_dt= Script_Search(step);
             scripts_ = Script_dt.Rows[0][2].ToString();
            
            textEditor_.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            textEditor_.Text = scripts_;
            host.Child = textEditor_;
            this.richTextBox3.Controls.Add(host);
            this.tabControl1.SelectedIndex = 2;
            xshd_stream.Close();
            //    this.richTextBox3.Controls.Remove(host);
            // this.richTextBox3.BringToFront();
            
        }
        private DataTable Script_Search(string step)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteConnection cn = new SQLiteConnection("data source=Scape.db");
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "Select * from T_Script where ID = '"+step+"'";
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cn.Close();
            return table;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void oKToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void stepEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            richTextBox2.Clear();
           Code_Compiler(textEditor_.Text);
            //Type a_type = results.CompiledAssembly.GetType();
            //MethodInfo method = a_type.GetMethod("Main");
            //object XML=  assembly_.CreateInstance("");
         
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
          if(compile_error == 0)
            {
                AppDomain domain = AppDomain.CreateDomain("Compiled SCAPE");
                domain.ExecuteAssembly(scripts_);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
        private void text_editor_DoubleClick(object sender, EventArgs e)
        {
      
        }
        //TextEditor temp;
        private void TextEditor__KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.LeftCtrl)
            {
                //temp.Text = textEditor_.Text;
                Console.WriteLine();
            }

        }
        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {
  
        }

        private void richTextBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}