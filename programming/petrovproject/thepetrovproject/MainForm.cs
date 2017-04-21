using System;
using Eto.Forms;
using Eto.Drawing;

namespace thepetrovproject
{
	/// <summary>
	/// Your application's main form
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public struct EmployneeName {
			private string fname, mname, lname;
			public EmployneeName(string first, string middle, string last)
			{
				fname = first;
				mname = middle;
				lname = last;
			}
			public string firstName {
				get {
					return fname;
				}
				set {
					fname = firstName;
				}
			}
			public string middleName {
				get {
					return mname;
				}
				set {
					mname = middleName;
				}
			}	public string lastName {
				get {
					return lname;
				}
				set {
					lname = lastName;
				}
			}
			public override string ToString ()
			{

				//da se rewizira
				return String.Format ("[EmployneeName: firstName={0}, middleName={1}, lastName={2}]", firstName, middleName, lastName);
			}
			public string Initials()
			{
				return (String.Format ("{0}{1}{2)",
					fname.Substring (0, 1),
					mname.Substring (0, 1),
					lname.Substring (0, 1)));
			}
			private void button_Click(object sender, EventArgs e)
			{
				string first, middle, last;
				first = TextBoxFirst.Text;
				middle = TextBoxMiddle.Text;
				last = TextBoxLast.Text;
				EmployneeName myName = new EmployneeName (first, middle, last);
				string fullname, inits;
				fullname = myName.ToString ();
				inits = myName.Initials ();
				rechTextBox1.Text = "Име на служителя=>" + fullname + "\n";
				RichTextBox1.Text += "Инициали на служителя =>" + inits;

		}
	}
}
}