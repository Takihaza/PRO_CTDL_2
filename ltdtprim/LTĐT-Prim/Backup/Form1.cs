using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
namespace algorithmass
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox XT;
		private System.Windows.Forms.TextBox YT;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox fc;
		private System.Windows.Forms.ComboBox tc;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			K = this;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.XT = new System.Windows.Forms.TextBox();
			this.YT = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.fc = new System.Windows.Forms.ComboBox();
			this.tc = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "file";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "save";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "open";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(464, 48);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(88, 24);
			this.checkBox1.TabIndex = 29;
			this.checkBox1.Text = "modify";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.XT,
																					this.YT,
																					this.textBox1,
																					this.label1,
																					this.label2,
																					this.label3,
																					this.fc,
																					this.tc,
																					this.textBox2,
																					this.label6,
																					this.label5,
																					this.label4});
			this.groupBox1.Location = new System.Drawing.Point(440, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 176);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Entery";
			// 
			// XT
			// 
			this.XT.Location = new System.Drawing.Point(192, 72);
			this.XT.Name = "XT";
			this.XT.Size = new System.Drawing.Size(72, 20);
			this.XT.TabIndex = 2;
			this.XT.Text = "";
			this.XT.TextChanged += new System.EventHandler(this.XT_TextChanged_1);
			// 
			// YT
			// 
			this.YT.Location = new System.Drawing.Point(112, 72);
			this.YT.Name = "YT";
			this.YT.Size = new System.Drawing.Size(72, 20);
			this.YT.TabIndex = 2;
			this.YT.Text = "";
			this.YT.TextChanged += new System.EventHandler(this.YT_TextChanged_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(80, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(192, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Name";
			// 
			// fc
			// 
			this.fc.Location = new System.Drawing.Point(176, 144);
			this.fc.Name = "fc";
			this.fc.Size = new System.Drawing.Size(96, 21);
			this.fc.TabIndex = 11;
			// 
			// tc
			// 
			this.tc.Location = new System.Drawing.Point(72, 144);
			this.tc.Name = "tc";
			this.tc.Size = new System.Drawing.Size(96, 21);
			this.tc.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(8, 144);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(56, 20);
			this.textBox2.TabIndex = 13;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 24);
			this.label6.TabIndex = 14;
			this.label6.Text = "cost";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(80, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "to";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "from";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(608, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 24);
			this.button4.TabIndex = 27;
			this.button4.Text = "calculate";
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(608, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 24);
			this.button2.TabIndex = 26;
			this.button2.Text = "insert link";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(608, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 25;
			this.button1.Text = "Insert node";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(448, 320);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(80, 108);
			this.listBox1.TabIndex = 30;
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(592, 320);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(80, 108);
			this.listBox2.TabIndex = 30;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(456, 296);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 31;
			this.label7.Text = "from";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(592, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "to";
			// 
			// listBox3
			// 
			this.listBox3.Location = new System.Drawing.Point(536, 320);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(40, 108);
			this.listBox3.TabIndex = 32;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(536, 304);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 16);
			this.label9.TabIndex = 33;
			this.label9.Text = "cost";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(720, 449);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label9,
																		  this.listBox3,
																		  this.label7,
																		  this.listBox1,
																		  this.checkBox1,
																		  this.groupBox1,
																		  this.button4,
																		  this.button2,
																		  this.button1,
																		  this.listBox2,
																		  this.label8});
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		private Pen pen=new Pen(Color.Black);
		private SolidBrush brush = new SolidBrush(Color.Black);
		private int  XTn,YTn;
		public static ArrayList arr = new ArrayList();
		private void button1_Click(object sender, System.EventArgs e)
		{
			//check that every textbox is full
			//
			if(((XT.Text).Length==0)||((YT.Text).Length==0)||(textBox1.Text).Length==0)
			{
				return;
			}
			//
			
			//so found the same name before that
			if(arr.Count>0)
			if((returnnode(textBox1.Text)==null)==false)
				return;
			//
			XTn=(int)Convert.ToInt64(XT.Text);
			YTn=(int)Convert.ToInt64(YT.Text);
			node n = new node();
			Point p = new Point(XTn,YTn);
			n.Center=p;
			n.name=textBox1.Text;
			n.drawc();
			//clear the texts
			arr.Add(n);
			XT.Clear();
			YT.Clear();			
			textBox1.Clear();
			///////////////////////////////////
			///keep the size of the aray
			int x= arr.Count;
			//clear the combo boxes
			fc.Items.Clear();
			tc.Items.Clear();
			//----------------------
			for(int i=0;i<x;i++)
			{
				fc.Items.Add(( (node)arr[i]).name );
				tc.Items.Add(( (node)arr[i]).name );
			}
		}
		//return the node according to its coordinates
		private static int returnnd(Point p)
		{
			for(int i=0;i<arr.Count;i++)
			{
				if( ((node)arr[i]).Center.X<p.X+25&&((node)arr[i]).Center.X>p.X-25&&((node)arr[i]).Center.Y<p.Y+25&&((node)arr[i]).Center.Y>p.Y-25)
				{
					return i;
				}
			}
			return -1;
		}
		public static Form K;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// to reduce flikering
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint , true);
			this.SetStyle(ControlStyles.UserPaint, true);
			


		}
	    public static ArrayList links = new ArrayList();
		private void button2_Click(object sender, System.EventArgs e)
		{
			S1=fc.Text;
			S2=tc.Text;
			if(S1==S2)
				return;
			
			if((fc.Text).Length==0||(tc.Text).Length==0||(textBox2.Text).Length==0)
				return;
			link l = new link(int.Parse(textBox2.Text),S1,S2);				
			l.Center1.X=(((returnnode( (fc.Text).ToString())))).Center.X+10;
			l.Center1.Y=(((returnnode( (fc.Text).ToString())))).Center.Y+10;
			l.Center2.X=(((returnnode(( tc.Text).ToString())))).Center.X+10;
			l.Center2.Y=(((returnnode(( tc.Text).ToString())))).Center.Y+10;
			l.from=S1;
			l.to=S2;
			l.drawline();
			links.Add(l);
		}
		node returnnode(string t)
		{
			int c= arr.Count;
			for(int i=0;i<c;i++)
			{
				if(t==((node)arr[i] ).name)
				{
					return ((node)arr[i] );
					
				}
			}
			return null;
		}
		int returnno(string t)
		{
			int c= arr.Count;
			for(int i=0;i<c;i++)
			{
				if(t==((node)arr[i] ).name)
				{
					return i ;
					
				}
			}
			return 0;
		}
				private void button4_Click(object sender, System.EventArgs e)
		{
		}
			static void  zero(long [,]matrix,int tempo)
			{
				
					for(int i=0;i<matrix.GetLength(1);i++)
					{
						matrix[i,tempo]=0;
					}
			}
		
		static long getminimum(long [,]arr,int[] index,out int where,ref int s)
		{
			int max=arr.GetLength(1);
			//temp 
			long temp=0;
			for(int j=0;j<index.Length;j++)
				for(int i=0;i<max;i++)
				{
					if(arr[index[j],i]>0)
					{
						temp=arr[index[j],i];
						break;
					}
				}
		
			where = 0;
			for(int j=0;j<index.Length;j++)
				for(int i=0;i<max;i++)
				{
					if(arr[index[j],i]<=temp&&arr[index[j],i]>0)
					{
						temp = arr[index[j],i];
						where=i;
						s=index[j];
					}
					//return the minimum no in the row	
				}
			return temp;
		}		
		//
		public static string S1,S2;
		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{		
			draw();			
		}

		private void XT_TextChanged(object sender, System.EventArgs e)
		{
			if(!Regex.Match(XT.Text,@"^[0-9]*$").Success )
			{
				XT.Clear();
			}
		}

		private void XT_Leave(object sender, System.EventArgs e)
		{		}

		
		public static link returnlink(string s1,string s2)
		{
			//create a link to keep the new link as a result of the two strings
			link newlink=new link();
			//
			for (int i=0;i<links.Count;i++)
			{					
				newlink=(link)links[i];
				// check for the returned link with the two names
				if(newlink.from==s1&&newlink.to==s2)
				{					
					return newlink;				
				}
				if(newlink.from==s2&&newlink.to==s1)
				{
					return newlink;					
				}
			}
			return null;
		}
		public static node nodefromstring(string s)
		{
			node newnode = new node();
			for(int i=0;i<arr.Count;i++)
			{
				newnode=(node)arr[i];
				if(newnode.name==s)
					return newnode;
			}
			return newnode;
		}
		//no get me string
		public static string [] restrarr(long[] A)
		{
			
			string [] strarr = new string[A.Length];
			for(int i=0;i<A.Length;i++)
			{
				//MessageBox.Show("FDDFFD"+((node)arr[ 1] ).name);
				 strarr[i]=((node)arr[ Convert.ToInt16(A[i])] ).name;
				//MessageBox.Show(strarr[i]+"DFSDSFaaaaaaaaaaa");
			}
			return strarr;
		}
		
		private FileStream fileoutput;
		private BinaryFormatter formater = new BinaryFormatter();
		
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			// the string to save the file name
			string filename ; 
			//----------------------------------

			//create object of type savefiledialog to use it to open the dialoug
			SaveFileDialog filechooser = new SaveFileDialog();
			//check the result 
			DialogResult result =filechooser.ShowDialog();
			// to all create new file without alerting
			filechooser.CheckFileExists=false;
			//--------------------------------------
			//if result is cancel abrot the funtion
			if(result == DialogResult.Cancel)
				return;
			//update the name of the file with the fixed extension"sbs"
			filename = filechooser.FileName+".sbs";
			if(filename==""||filename==null)
				MessageBox.Show("Invalid file name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				
				fileoutput=new FileStream(filename,FileMode.OpenOrCreate,FileAccess.Write);
				// save the size of links and arr arrays
				formater.Serialize(fileoutput,arr.Count);
				formater.Serialize(fileoutput,links.Count);
				//--------------------
				for(int i=0;i<links.Count;i++)
				{
					// save the links data
					formater.Serialize(fileoutput,((link)links[i]).Center1);
					formater.Serialize(fileoutput,((link)links[i]).Center2);
					formater.Serialize(fileoutput,((link)links[i]).distance);
					formater.Serialize(fileoutput,((link)links[i]).from);
					formater.Serialize(fileoutput,((link)links[i]).to);
					//end
					
				}
				for(int i=0;i<arr.Count;i++)
				{
					//save the nodes data
					formater.Serialize(fileoutput,((node)arr[i]).Center);
					formater.Serialize(fileoutput,((node)arr[i]).name);
					//end
				}
				
					if(fileoutput!=null)
				{
					try
					{
						fileoutput.Close();
					}
					catch(IOException)
					{
						MessageBox.Show("Can't close file !","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
		}
		// object needed in serialization
		BinaryFormatter reader = new BinaryFormatter();
		FileStream file;
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//
			// user dosn't choose any node
			selected_node=-1;
			////////////////////
			string filename ; 
			OpenFileDialog filechooser = new OpenFileDialog();
			DialogResult result =filechooser.ShowDialog();
			//if user pressed cancel abrot the function
			if(result == DialogResult.Cancel)
				return;
			//----
			// empty the arrays to clear the screan as thesea arrats used to draw
			// the nodes and the links
			arr  = new ArrayList();
			links = new ArrayList();
			filename = filechooser.FileName;
			if(filename==""||filename==null)
				MessageBox.Show("Invalid file name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				try
				{
					// creat a new filestream object to use in serialization
					file=new FileStream(filename,FileMode.Open,FileAccess.Read);
					// creat new objects to save the retuned data from reading
					node newone = new node();
					link nwelink = new link();
					//------				
				int nodesmax=(int )reader.Deserialize(file);
					int linksmax=(int)reader.Deserialize(file);
				//load the links from the file	
					for(int i=0;i<linksmax;i++)
					{
						nwelink = new link();
						nwelink.Center1 = (Point)reader.Deserialize(file);
						nwelink.Center2 = (Point)reader.Deserialize(file);
						
						nwelink.distance= (long)reader.Deserialize(file);
						
						nwelink.from = (string)reader.Deserialize(file);
						
						nwelink.to = (string)reader.Deserialize(file);
						links.Add(nwelink);
					}
					for(int i=0;i<nodesmax;i++)
					{
						newone = new node();
						newone.Center=(Point)reader.Deserialize(file);					
						newone.name=(string)reader.Deserialize(file);
						
						arr.Add(newone);
					}
				}
					// catch for error 
				catch(FileNotFoundException)
				{
					MessageBox.Show("File dosn't exsist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}


			}
			//clear the combo
			fc.Items.Clear();			
			tc.Items.Clear();
			///
			//fill the combo boxes
			for(int i=0;i<arr.Count;i++)
			{
				fc.Items.Add(( (node)arr[i]).name );
				tc.Items.Add(( (node)arr[i]).name );
			}
			//fill the lists
			for(int i=0;i<links.Count;i++)
			{
				listBox1.Items.Add(((link)links[i]).from);
				listBox2.Items.Add(((link)links[i]).to);
				listBox3.Items.Add(((link)links[i]).distance);
			}
			this.Refresh();
			
			draw();
		}
		int selected_node = -1 ;
		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//ensure that the user dosn't choose any other node
			selected_node=-1;
			//-----
			// if the user checked the checkbox labled modify
			if(checkBox1.Checked==true)							
			{
				// keep the current poing
				Point pa = new Point(e.X,e.Y);
				//if the user was clicking on the space do nothing and abrot
				if(returnnd(pa)==-1)
					return;
				//else save the selected node in selected_node
				selected_node = returnnd(pa);
				return;
			}
			if((returnnode(textBox1.Text)==null)==false)
				return;
			if(textBox1.Text=="")
				return;
			XTn=e.X;
			YTn=e.Y;
			node n = new node();
			Point p = new Point(XTn,YTn);
			n.Center=p;
			n.name=textBox1.Text;
			n.drawc();
			arr.Add(n);
			XT.Clear();
			YT.Clear();
			textBox1.Clear();
			int x= arr.Count;
			fc.Items.Clear();
			tc.Items.Clear();
			for(int i=0;i<x;i++)
			{
				fc.Items.Add(( (node)arr[i]).name );
				tc.Items.Add(( (node)arr[i]).name );
			}
		}

		private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//check if the user checked the checkbox1 and he selected an appropriate node
			if (selected_node!=-1&&checkBox1.Checked==true)
			{
				//creat new node save the current possitin while the mouse move
				Point pa = new Point(e.X,e.Y);
				//determine a region to invalidate to reduce flickering
				Rectangle rec = new Rectangle(e.X-40,e.Y-40,90,90);
				Region reg = new Region(rec);
				//-------------------------------				
				//upate the center of the selected node 				
				((node)arr[selected_node] ).setcenter(pa);
				//redraw the screen
				this.Invalidate(reg);				
				//--
			}
		}

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// determine a region to redraw the screan to reduce flickering
			Rectangle rec = new Rectangle(e.X-40,e.Y-40,90,90);
			Region reg = new Region(rec);
			//-------------------------------------------------------			
			if(checkBox1.Checked==true&&selected_node>-1)
			{
				//save the position where the user released the button of the mouse 
				Point pa = new Point(e.X,e.Y);
				//update the node
				((node)arr[selected_node] ).setcenter(pa);				
				///
				link l = new link();
				//update all the links for the moved node
				for(int i=0;i<arr.Count;i++)
				{					
					if(i!=selected_node)
					{						
						if(returnlink(((node)arr[selected_node]).name,((node)arr[i]).name)==null)
							continue;
						l=returnlink(((node)arr[selected_node]).name,((node)arr[i]).name);                       
						if(l.from==((node)arr[selected_node]).name)
						{
							l.setcenter(pa);
						}
						else
							l.setcenter1(pa);
					}
				}
				/////					
				// redraw the screan again with the updated data
				this.Refresh();			
				draw();			
			}
			///user dosn't select any node now		
			selected_node=-1;
		}
		private void button4_Click_1(object sender, System.EventArgs e)
		{		
			//put the data in array two dimension and 
			//use the algorithm
			// value that keep the next node
			int next_node=0;
			//array to save all the nodes to check in the algorithm of prim's algorithm
			int arrsize=arr.Count;
			//////////
			///---------------------------------
			int [] arr1 = new int[arrsize];
			long [,]matrix = new long[arrsize,arrsize];
			///
			for(int i=0;i<arrsize;i++)
				for(int j=0;j<arrsize;j++)
				{
					matrix[i,j]=0;
				}
			//
			// froM is the index of the node in the links array [from]
			// tO is the inex of the node in the links array [to]
			int froM,tO;
			//---------------------------
			//fill the matrix with the data in each link
			for(int i=0;i<links.Count;i++)
			{
				froM=returnno( ((link)links[i] ).from);
				tO=returnno(((link)links[i] ).to);				
				matrix[froM,tO]=((link)links[i]).distance;
				matrix[tO,froM]=((link)links[i]).distance;                				
			}
			//where --> keep the index of the minimum variable [the column of it]
			int Where=0;
			// keep the sum of the shortest distance
			long sum=0;
			//keep the row where we check			
			//-----------------------
			long minimum_no=0;
			//new array to save the new links after calculiting the shortest rout
			ArrayList linkaton = new ArrayList();
			for(int i=0;i<arrsize;i++)
			{				
				//save in an array called arr1 the nodes we wanna check every time
				arr1[i]=Where;
				//zero the column of the first element
				zero(matrix,arr1[i]);
				//get the minimum value
				minimum_no=getminimum(matrix,arr1,out Where,ref next_node);
				// if the minimum_no = 0 so stop calculiting and finisht he function
				if(minimum_no!=0)
				{
					sum+=minimum_no;
					//add new node to links array
					link l1 = new link();
					l1=returnlink(((node)arr[next_node]).name,((node)arr[Where]).name);
					//add the new link in linkatoin array that we will use to draw
					// again with the updated data after calculatin
					linkaton.Add(l1);
					/////////////////////////////
				}						
			}
			// update the screen with the new node
			this.Refresh();
			links=linkaton;
			draw();
			//////////////////////////////////////			
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			//check that every textbox is full
			//
			if(((XT.Text).Length==0)||((YT.Text).Length==0)||(textBox1.Text).Length==0)
			{
				return;
			}
			//			
			//so found the same name before that
			if(arr.Count>0)
				if((returnnode(textBox1.Text)==null)==false)
					return;
			//fetch the data from the screen and insert it in the new object of node			
			XTn=(int)Convert.ToInt64(XT.Text);
			YTn=(int)Convert.ToInt64(YT.Text);
			node n = new node();
			//creat a new point to keep the position where the user want to insert the 
			//new node
			Point p = new Point(XTn,YTn);
			//put the data in the object
			n.Center=p;
			n.name=textBox1.Text;
			//draw the node
			n.drawc();
			//add the new node in the array
			arr.Add(n);
			//clear the text boxes
			XT.Clear();
			YT.Clear();
			textBox1.Clear();
			//keep the size of the array of nodes
			int x= arr.Count;
			//clear the combo boxes
			fc.Items.Clear();
			tc.Items.Clear();
			//--
			//fill the combo boxes with the nodes kept in arr [ array of nodes]
			for(int i=0;i<x;i++)
			{
				fc.Items.Add(( (node)arr[i]).name );
				tc.Items.Add(( (node)arr[i]).name );
			}
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			//keep the seleced text in the combo boxes
			S1=fc.Text;
			S2=tc.Text;
			//check if the user wanna insert a link between the same city do notihng
			if(S1==S2)
				return;
			////////
			///check if there are another link has the same info 			
			if(returnlink((fc.Text),tc.Text)!=null)
				return;
            //--------------
			//check if the user didn't insert the necessery information about the link
			if((fc.Text).Length==0||(tc.Text).Length==0||(textBox2.Text).Length==0)
				return;
			// creat new link and use its constructor to add the neccesrry data
			link l = new link(int.Parse(textBox2.Text),S1,S2);
			//

			l.Center1.X=(((returnnode( (fc.Text).ToString())))).Center.X+10;
			l.Center1.Y=(((returnnode( (fc.Text).ToString())))).Center.Y+10;
			l.Center2.X=(((returnnode(( tc.Text).ToString())))).Center.X+10;
			l.Center2.Y=(((returnnode(( tc.Text).ToString())))).Center.Y+10;
			//add in list box
			listBox1.Items.Add(l.from);
			listBox3.Items.Add(int.Parse(textBox2.Text));
			listBox2.Items.Add(l.to);
			// call the drawline function in link class
			l.drawline();
			//add link the array
			links.Add(l);
		}

		private void XT_TextChanged_1(object sender, System.EventArgs e)
		{
			// to check if the user entered by wrong wrong type
			if(!Regex.Match(XT.Text,@"^[0-9]*$").Success )
			{
				XT.Clear();
			}
		}

		
		private void textBox2_TextChanged_1(object sender, System.EventArgs e)
		{
			// to check if the user entered by wrong wrong type
			if(!Regex.Match(textBox2.Text,@"^[0-9]*$").Success )
			{
				textBox2.Clear();
			}
		}
		private void YT_TextChanged_1(object sender, System.EventArgs e)
		{
			// to check if the user entered by wrong wrong type
			if(!Regex.Match(YT.Text,@"^[0-9]*$").Success )
			{
				YT.Clear();
			}
		}
		static void draw()
		{
			// the function that draw the nodes and the links
			//by iterating on them and call draw fun in each object there
			//this fun on_paint call it
			node newnode = new node();
			for(int i=0;i<arr.Count;i++)
			{
				newnode = ((node)arr[i] );
				newnode.drawc();
			}
			link newlink=new link();
			for(int i=0;i<links.Count;i++)
			{
				newlink=(link)links[i];
				if(newlink==null)
					return;
				newlink.drawline();
			}
		}
	}
}
