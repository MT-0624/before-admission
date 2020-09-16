// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button2_Click(object sender, EventArgs e)
{
	if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	checked
	{
		int num = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		int num2 = (int)Math.Round(Conversions.ToDouble(TextBox12.Text) * 1000.0 / 2.0);
		int num3;
		int num4;
		if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
		{
			num3 = 2;
			num4 = 6;
		}
		else
		{
			num3 = 1;
			num4 = 4;
		}
		int num5;
		if (Conversions.ToDouble(ComboBox3.Text) == 5.0)
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) >= 30.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) >= 60.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 6.0) | (Conversions.ToDouble(ComboBox3.Text) == 7.0))
		{
			num5 = 12000 * num3;
			TextBox5.Text = "跳満";
		}
		else if (((Conversions.ToDouble(ComboBox3.Text) == 8.0) | (Conversions.ToDouble(ComboBox3.Text) == 9.0)) || Conversions.ToDouble(ComboBox3.Text) == 10.0)
		{
			num5 = 16000 * num3;
			TextBox5.Text = "倍満";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 11.0) | (Conversions.ToDouble(ComboBox3.Text) == 12.0))
		{
			num5 = 24000 * num3;
			TextBox5.Text = "三倍満";
		}
		else if (Conversions.ToDouble(ComboBox3.Text) == 13.0)
		{
			num5 = 32000 * num3;
			TextBox5.Text = "役満";
		}
		else
		{
			double a = Conversions.ToDouble(TextBox4.Text) * (double)num4 * Math.Pow(2.0, Conversions.ToDouble(ComboBox3.Text) + 2.0) / 100.0;
			double a2 = Math.Ceiling(a) * 100.0;
			num5 = (int)Math.Round(a2);
		}
		if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 30.0))
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1500.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(800 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(800 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(700 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(500 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(500 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 2.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(900 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(600 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(900 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 3900.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(2000 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1700 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 7700.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(3900 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(3900 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(3200 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(2000 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(3200 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 40.0))
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(900 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(600 + num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(900 + num2));
			}
		}
		else
		{
			Label9.Text = Conversions.ToString(num5);
			double a3 = (double)num5 / 100.0;
			double num6 = Math.Ceiling(a3);
			double a4 = num6 * 5.0 / 8.0;
			double a5 = num6 * 3.0 / 8.0;
			double a6 = num6 * 1.0 / 2.0;
			double num7 = Math.Ceiling(a5) * 100.0;
			double num8 = Math.Ceiling(a4) * 100.0;
			double num9 = Math.Ceiling(a6) * 100.0;
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + num9 * 2.0 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num9 + (double)num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num9 + (double)num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num8 + (double)num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num7 + (double)num2));
			}
			else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num7 + (double)num2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num8 + (double)num2));
			}
		}
		TextBox19.Text = Conversions.ToString(0);
		Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
		Button18.Visible = true;
		Button19.Visible = true;
	}
}

// Sanmate.Form1
using System;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button1_Click(object sender, EventArgs e)
{
	if (!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked)
	{
		Interaction.MsgBox("起家を選択してください");
		return;
	}
	int value = 1;
	int value2 = 0;
	TextBox9.Text = Conversions.ToString(value);
	TextBox12.Text = Conversions.ToString(value2);
	Button1.Visible = false;
	NumericUpDown1.Visible = false;
	NumericUpDown2.Visible = false;
	NumericUpDown3.Visible = false;
	RadioButton1.Visible = false;
	RadioButton2.Visible = false;
	RadioButton3.Visible = false;
	RadioButton4.Visible = true;
	RadioButton5.Visible = true;
	RadioButton6.Visible = true;
	TextBox1.Visible = true;
	TextBox2.Visible = true;
	TextBox3.Visible = true;
	ComboBox3.Visible = true;
	TextBox5.Visible = true;
	TextBox6.Visible = true;
	TextBox7.Visible = true;
	TextBox8.Visible = true;
	TextBox9.Visible = true;
	TextBox10.Visible = true;
	TextBox11.Visible = true;
	TextBox12.Visible = true;
	TextBox16.Visible = true;
	TextBox17.Visible = true;
	TextBox18.Visible = true;
	Label9.Visible = true;
	TextBox20.Visible = true;
	Button4.Visible = true;
	Button5.Visible = true;
	Button2.Visible = true;
	Button6.Visible = true;
	Button8.Visible = true;
	Button9.Visible = true;
	Button10.Visible = true;
	Button11.Visible = true;
	Button12.Visible = true;
	Button13.Visible = true;
	Button15.Visible = true;
	Button16.Visible = true;
	Button14.Visible = true;
	ComboBox1.Visible = false;
	LinkLabel1.Visible = true;
	LinkLabel2.Visible = true;
	GroupBox1.Visible = true;
	TextBox19.Visible = true;
	PictureBox1.Visible = true;
	Label10.Visible = true;
	Label11.Visible = true;
	int num = 35000;
	TextBox1.Text = Conversions.ToString(35000);
	TextBox2.Text = Conversions.ToString(35000);
	TextBox3.Text = Conversions.ToString(35000);
	TextBox9.Text = Conversions.ToString(1);
	if (RadioButton1.Checked)
	{
		TextBox13.Text = Conversions.ToString(1.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox14.Text = Conversions.ToString(3.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox15.Text = Conversions.ToString(2.0 - Conversions.ToDouble(TextBox9.Text));
	}
	if (RadioButton2.Checked)
	{
		TextBox13.Text = Conversions.ToString(2.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox14.Text = Conversions.ToString(1.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox15.Text = Conversions.ToString(3.0 - Conversions.ToDouble(TextBox9.Text));
	}
	if (RadioButton3.Checked)
	{
		TextBox13.Text = Conversions.ToString(3.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox14.Text = Conversions.ToString(2.0 - Conversions.ToDouble(TextBox9.Text));
		TextBox15.Text = Conversions.ToString(1.0 - Conversions.ToDouble(TextBox9.Text));
	}
	if (Conversions.ToDouble(TextBox13.Text) == 0.0)
	{
		TextBox16.Text = "東";
		TextBox17.Text = "西";
		TextBox18.Text = "南";
	}
	else if (Conversions.ToDouble(TextBox14.Text) == 0.0)
	{
		TextBox16.Text = "南";
		TextBox17.Text = "東";
		TextBox18.Text = "西";
	}
	else if (Conversions.ToDouble(TextBox15.Text) == 0.0)
	{
		TextBox16.Text = "西";
		TextBox17.Text = "南";
		TextBox18.Text = "東";
	}
	if (Conversions.ToDouble(TextBox13.Text) == 0.0)
	{
		TextBox16.BackColor = Color.Red;
		TextBox17.BackColor = Color.Blue;
		TextBox18.BackColor = Color.Blue;
	}
	if (Conversions.ToDouble(TextBox14.Text) == 0.0)
	{
		TextBox16.BackColor = Color.Blue;
		TextBox17.BackColor = Color.Red;
		TextBox18.BackColor = Color.Blue;
	}
	if (Conversions.ToDouble(TextBox15.Text) == 0.0)
	{
		TextBox16.BackColor = Color.Blue;
		TextBox17.BackColor = Color.Blue;
		TextBox18.BackColor = Color.Red;
	}
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

private void Button3_Click_1(object sender, EventArgs e)
{
	Random random = new Random();
	int value = random.Next(2, 12);
	MessageBox.Show(Conversions.ToString(value), "2つのサイコロを振りました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button4_Click(object sender, EventArgs e)
{
	if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	checked
	{
		int num = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		int num2 = (int)Math.Round(Conversions.ToDouble(TextBox12.Text) * 1000.0 / 2.0);
		int num3;
		int num4;
		if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
		{
			num3 = 2;
			num4 = 6;
		}
		else
		{
			num3 = 1;
			num4 = 4;
		}
		int num5;
		if (Conversions.ToDouble(ComboBox3.Text) == 5.0)
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) >= 30.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) >= 60.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 6.0) | (Conversions.ToDouble(ComboBox3.Text) == 7.0))
		{
			num5 = 12000 * num3;
			TextBox5.Text = "跳満";
		}
		else if (((Conversions.ToDouble(ComboBox3.Text) == 8.0) | (Conversions.ToDouble(ComboBox3.Text) == 9.0)) || Conversions.ToDouble(ComboBox3.Text) == 10.0)
		{
			num5 = 16000 * num3;
			TextBox5.Text = "倍満";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 11.0) | (Conversions.ToDouble(ComboBox3.Text) == 12.0))
		{
			num5 = 24000 * num3;
			TextBox5.Text = "三倍満";
		}
		else if (Conversions.ToDouble(ComboBox3.Text) == 13.0)
		{
			num5 = 32000 * num3;
			TextBox5.Text = "役満";
		}
		else
		{
			double a = Conversions.ToDouble(TextBox4.Text) * (double)num4 * Math.Pow(2.0, Conversions.ToDouble(ComboBox3.Text) + 2.0) / 100.0;
			double a2 = Math.Ceiling(a) * 100.0;
			num5 = (int)Math.Round(a2);
		}
		if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 30.0))
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1500.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(800 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(800 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(700 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(500 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(500 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 2.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(900 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(600 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(900 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 3900.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(2000 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1700 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 7700.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(3900 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(3900 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(3200 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(2000 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(3200 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 40.0))
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(1100 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(900 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (double)(600 + num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(900 + num2));
			}
		}
		else
		{
			Label9.Text = Conversions.ToString(num5);
			double a3 = (double)num5 / 100.0;
			double num6 = Math.Ceiling(a3);
			double a4 = num6 * 5.0 / 8.0;
			double a5 = num6 * 3.0 / 8.0;
			double a6 = num6 * 1.0 / 2.0;
			double num7 = Math.Ceiling(a5) * 100.0;
			double num8 = Math.Ceiling(a4) * 100.0;
			double num9 = Math.Ceiling(a6) * 100.0;
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + num9 * 2.0 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num9 + (double)num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num9 + (double)num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num8 + (double)num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num7 + (double)num2));
			}
			else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num7 + (double)num2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num8 + (double)num2));
			}
		}
		TextBox19.Text = Conversions.ToString(0);
		Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
		Button18.Visible = true;
		Button19.Visible = true;
	}
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button5_Click(object sender, EventArgs e)
{
	if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
	{
		MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		return;
	}
	checked
	{
		int num = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		int num2 = (int)Math.Round(Conversions.ToDouble(TextBox12.Text) * 1000.0 / 2.0);
		int num3;
		int num4;
		if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
		{
			num3 = 2;
			num4 = 6;
		}
		else
		{
			num3 = 1;
			num4 = 4;
		}
		int num5;
		if (Conversions.ToDouble(ComboBox3.Text) == 5.0)
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) >= 30.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) >= 60.0))
		{
			num5 = 8000 * num3;
			TextBox5.Text = "満貫";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 6.0) | (Conversions.ToDouble(ComboBox3.Text) == 7.0))
		{
			num5 = 12000 * num3;
			TextBox5.Text = "跳満";
		}
		else if (((Conversions.ToDouble(ComboBox3.Text) == 8.0) | (Conversions.ToDouble(ComboBox3.Text) == 9.0)) || Conversions.ToDouble(ComboBox3.Text) == 10.0)
		{
			num5 = 16000 * num3;
			TextBox5.Text = "倍満";
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 11.0) | (Conversions.ToDouble(ComboBox3.Text) == 12.0))
		{
			num5 = 24000 * num3;
			TextBox5.Text = "三倍満";
		}
		else if (Conversions.ToDouble(ComboBox3.Text) == 13.0)
		{
			num5 = 32000 * num3;
			TextBox5.Text = "役満";
		}
		else
		{
			double a = Conversions.ToDouble(TextBox4.Text) * (double)num4 * Math.Pow(2.0, Conversions.ToDouble(ComboBox3.Text) + 2.0) / 100.0;
			double a2 = Math.Ceiling(a) * 100.0;
			num5 = (int)Math.Round(a2);
		}
		if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 30.0))
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1500.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(800 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(800 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(700 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(500 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(500 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 2.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(900 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(600 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(900 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 3.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 3900.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(2000 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1700 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 2600.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1700 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 4.0) & (Conversions.ToDouble(TextBox4.Text) == 20.0))
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 7700.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(3900 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(3900 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(3200 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(2000 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 5200.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(2000 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(3200 + num2));
			}
		}
		else if ((Conversions.ToDouble(ComboBox3.Text) == 1.0) & (Conversions.ToDouble(TextBox4.Text) == 40.0))
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 2000.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(1100 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(1100 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(900 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(600 + num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1300.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (double)(600 + num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (double)(900 + num2));
			}
		}
		else
		{
			Label9.Text = Conversions.ToString(num5);
			double a3 = (double)num5 / 100.0;
			double num6 = Math.Ceiling(a3);
			double a4 = num6 * 5.0 / 8.0;
			double a5 = num6 * 3.0 / 8.0;
			double a6 = num6 * 1.0 / 2.0;
			double num7 = Math.Ceiling(a5) * 100.0;
			double num8 = Math.Ceiling(a4) * 100.0;
			double num9 = Math.Ceiling(a6) * 100.0;
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + num9 * 2.0 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num9 + (double)num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num9 + (double)num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num8 + (double)num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num7 + (double)num2));
			}
			else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + num7 + num8 + (double)num + (double)(num2 * 2));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num7 + (double)num2));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num8 + (double)num2));
			}
		}
		TextBox19.Text = Conversions.ToString(0);
		Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
		Button18.Visible = true;
		Button19.Visible = true;
	}
}

// Sanmate.Form1
using System;

private void Button6_Click(object sender, EventArgs e)
{
	CheckBox1.Visible = true;
	CheckBox3.Visible = true;
	CheckBox2.Visible = true;
	Label20.Visible = true;
	Button17.Visible = true;
}

// Sanmate.Form1
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button8_Click(object sender, EventArgs e)
{
	int num;
	int num2;
	int num3;
	int num6 = default(int);
	int num7 = default(int);
	int num9;
	double num5 = default(double);
	int num8;
	checked
	{
		num = (int)Math.Round(1000.0 * Conversions.ToDouble(TextBox12.Text));
		num2 = 2;
		PictureBox2.Visible = false;
		PictureBox3.Visible = false;
		PictureBox4.Visible = false;
		Button18.Visible = true;
		Button19.Visible = true;
		num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		string right = default(string);
		string right2 = default(string);
		string right3 = default(string);
		string right4 = default(string);
		string right5 = default(string);
		if (Operators.CompareString(ComboBox3.Text, right, TextCompare: false) == 0)
		{
			double num4 = 64000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right2, TextCompare: false) == 0)
		{
			double num4 = 96000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right3, TextCompare: false) == 0)
		{
			double num4 = 128000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right4, TextCompare: false) == 0)
		{
			double num4 = 160000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right5, TextCompare: false) == 0)
		{
			double num4 = 192000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else
		{
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
			num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
		}
		if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
		{
			num8 = 6;
			num5 = 1.5;
		}
		else
		{
			num8 = 4;
			num5 = 1.0;
		}
		num9 = Conversions.ToInteger(TextBox12.Text);
	}
	if (num7 == 5)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 6 || num7 == 7)
	{
		double num4 = 12000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 8 || num7 == 9 || num7 == 10)
	{
		double num4 = 16000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 11 || num7 == 12)
	{
		double num4 = 24000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 13)
	{
		double num4 = 32000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 3 && num6 >= 60)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 4 && num6 >= 30)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else
	{
		checked
		{
			double a = (double)(num6 * num8) * Math.Pow(2.0, num7 + num2) / 100.0;
			double num10 = Math.Ceiling(a);
			num10 = (num10 + (double)(num9 * 3)) * 100.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num10 + (double)num3 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num10 + (double)num3 + (double)num));
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
	Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
}

// Sanmate.Form1
using System;

private void Button7_Click(object sender, EventArgs e)
{
	Close();
}

// Sanmate.Form1
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button9_Click(object sender, EventArgs e)
{
	int num;
	int num2;
	int num3;
	int num6 = default(int);
	int num7 = default(int);
	int num9;
	double num5 = default(double);
	int num8;
	checked
	{
		num = (int)Math.Round(1000.0 * Conversions.ToDouble(TextBox12.Text));
		num2 = 2;
		PictureBox2.Visible = false;
		PictureBox3.Visible = false;
		PictureBox4.Visible = false;
		Button18.Visible = true;
		Button19.Visible = true;
		num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		string right = default(string);
		string right2 = default(string);
		string right3 = default(string);
		string right4 = default(string);
		string right5 = default(string);
		if (Operators.CompareString(ComboBox3.Text, right, TextCompare: false) == 0)
		{
			double num4 = 64000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right2, TextCompare: false) == 0)
		{
			double num4 = 96000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right3, TextCompare: false) == 0)
		{
			double num4 = 128000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right4, TextCompare: false) == 0)
		{
			double num4 = 160000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right5, TextCompare: false) == 0)
		{
			double num4 = 192000.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else
		{
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
			num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
		}
		if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
		{
			num8 = 6;
			num5 = 1.5;
		}
		else
		{
			num8 = 4;
			num5 = 1.0;
		}
		num9 = Conversions.ToInteger(TextBox12.Text);
	}
	if (num7 == 5)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton5.Checked)
		{
			if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 6 || num7 == 7)
	{
		double num4 = 12000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 8 || num7 == 9 || num7 == 10)
	{
		double num4 = 16000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 11 || num7 == 12)
	{
		double num4 = 24000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 13)
	{
		double num4 = 32000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 3 && num6 >= 60)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 4 && num6 >= 30)
	{
		double num4 = 8000.0;
		if (RadioButton4.Checked)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else
	{
		checked
		{
			double a = (double)(num6 * num8) * Math.Pow(2.0, num7 + num2) / 100.0;
			double num10 = Math.Ceiling(a);
			num10 = (num10 + (double)(num9 * 3)) * 100.0;
			if (RadioButton4.Checked)
			{
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - (num10 + (double)num3 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num10 + (double)num3 + (double)num));
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
	Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
}

// Sanmate.Form1
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button10_Click(object sender, EventArgs e)
{
	int num;
	int num2;
	int num3;
	int num6 = default(int);
	int num7 = default(int);
	int num9;
	double num5 = default(double);
	int num8;
	checked
	{
		num = (int)Math.Round(1000.0 * Conversions.ToDouble(TextBox12.Text));
		num2 = 2;
		PictureBox2.Visible = false;
		PictureBox3.Visible = false;
		PictureBox4.Visible = false;
		Button18.Visible = true;
		Button19.Visible = true;
		num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
		if (Operators.CompareString(ComboBox3.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("翻数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.CompareString(TextBox4.Text, string.Empty, TextCompare: false) == 0)
		{
			MessageBox.Show("絶対に符数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		string right = default(string);
		string right2 = default(string);
		string right3 = default(string);
		string right4 = default(string);
		string right5 = default(string);
		if (Operators.CompareString(ComboBox3.Text, right, TextCompare: false) == 0)
		{
			double num4 = 64000.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right2, TextCompare: false) == 0)
		{
			double num4 = 96000.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right3, TextCompare: false) == 0)
		{
			double num4 = 128000.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right4, TextCompare: false) == 0)
		{
			double num4 = 160000.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else if (Operators.CompareString(ComboBox3.Text, right5, TextCompare: false) == 0)
		{
			double num4 = 192000.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num4 * num5);
				Label9.ForeColor = Color.DarkGoldenrod;
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		else
		{
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
			num3 = (int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0);
			num6 = Conversions.ToInteger(TextBox4.Text);
			num7 = Conversions.ToInteger(ComboBox3.Text);
		}
		if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
		{
			num8 = 6;
			num5 = 1.5;
		}
		else
		{
			num8 = 4;
			num5 = 1.0;
		}
		num9 = Conversions.ToInteger(TextBox12.Text);
	}
	if (num7 == 5)
	{
		double num4 = 8000.0;
		if (RadioButton5.Checked)
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
			{
				num8 = 6;
				num5 = 1.5;
			}
			else
			{
				num8 = 4;
				num5 = 1.0;
			}
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 6 || num7 == 7)
	{
		double num4 = 12000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Green;
			TextBox5.Text = "跳満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 8 || num7 == 9 || num7 == 10)
	{
		double num4 = 16000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Red;
			TextBox5.Text = "倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 11 || num7 == 12)
	{
		double num4 = 24000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Purple;
			TextBox5.Text = "三倍満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 13)
	{
		double num4 = 32000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.DarkGoldenrod;
			TextBox5.Text = "役満";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 3 && num6 >= 60)
	{
		double num4 = 8000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else if (num7 == 4 && num6 >= 30)
	{
		double num4 = 8000.0;
		if (RadioButton5.Checked)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else if (RadioButton6.Checked)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num4 * num5 + (double)num));
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num4 * num5 + (double)num3 + (double)num));
			TextBox19.Text = Conversions.ToString(0);
			Label9.Text = Conversions.ToString(num4 * num5);
			Label9.ForeColor = Color.Blue;
			TextBox5.Text = "満貫";
		}
		else
		{
			MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	else
	{
		checked
		{
			double a = (double)(num6 * num8) * Math.Pow(2.0, num7 + num2) / 100.0;
			double num10 = Math.Ceiling(a);
			num10 = (num10 + (double)(num9 * 3)) * 100.0;
			if (RadioButton5.Checked)
			{
				TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - (num10 + (double)num3 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else if (RadioButton6.Checked)
			{
				TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - (num10 + (double)num3 + (double)num));
				TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (num10 + (double)num3 + (double)num));
				TextBox19.Text = Conversions.ToString(0);
				Label9.Text = Conversions.ToString(num10);
				Label9.ForeColor = Color.Black;
				TextBox5.Text = "";
			}
			else
			{
				MessageBox.Show("放銃者が正しく選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
	Interaction.MsgBox("精算ができたら\r\n右下の2つのボタンから進行を選択してください");
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

private void Button11_Click(object sender, EventArgs e)
{
	switch (MessageBox.Show("他家に満貫払いします、よろしいですか？", "チョンボ", MessageBoxButtons.OKCancel))
	{
	case DialogResult.OK:
		if (PictureBox2.Visible)
		{
			Button14.Visible = true;
			PictureBox2.Visible = false;
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox3.Visible)
		{
			Button15.Visible = true;
			PictureBox3.Visible = false;
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox4.Visible)
		{
			Button16.Visible = true;
			PictureBox4.Visible = false;
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		if (Operators.CompareString(TextBox17.Text, "東", TextCompare: false) == 0)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 6000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 6000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 12000.0);
		}
		else if (Operators.CompareString(TextBox17.Text, "南", TextCompare: false) == 0)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 3000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 5000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 8000.0);
		}
		else if (Operators.CompareString(TextBox17.Text, "西", TextCompare: false) == 0)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 3000.0);
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 5000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 8000.0);
		}
		MessageBox.Show("精算しました、そのまま対局を続行してください", "満貫が支払われました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		break;
	}
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

private void Button13_Click(object sender, EventArgs e)
{
	switch (MessageBox.Show("他家に満貫払いします、よろしいですか？", "チョンボ", MessageBoxButtons.OKCancel))
	{
	case DialogResult.OK:
		if (PictureBox2.Visible)
		{
			Button14.Visible = true;
			PictureBox2.Visible = false;
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox3.Visible)
		{
			Button15.Visible = true;
			PictureBox3.Visible = false;
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox4.Visible)
		{
			Button16.Visible = true;
			PictureBox4.Visible = false;
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		if (Operators.CompareString(TextBox16.Text, "東", TextCompare: false) == 0)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 6000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 6000.0);
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 12000.0);
		}
		else if (Operators.CompareString(TextBox16.Text, "南", TextCompare: false) == 0)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 3000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 5000.0);
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 8000.0);
		}
		else if (Operators.CompareString(TextBox16.Text, "西", TextCompare: false) == 0)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 3000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 5000.0);
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 8000.0);
		}
		MessageBox.Show("精算しました、そのまま対局を続行してください", "満貫が支払われました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		break;
	}
}

// Sanmate.Form1
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

private void Button12_Click(object sender, EventArgs e)
{
	switch (MessageBox.Show("他家に満貫払いします、よろしいですか？", "チョンボ", MessageBoxButtons.OKCancel))
	{
	case DialogResult.OK:
		if (PictureBox2.Visible)
		{
			Button14.Visible = true;
			PictureBox2.Visible = false;
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox3.Visible)
		{
			Button15.Visible = true;
			PictureBox3.Visible = false;
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		else if (PictureBox4.Visible)
		{
			Button16.Visible = true;
			PictureBox4.Visible = false;
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1000.0);
			TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) - 1.0);
		}
		if (Operators.CompareString(TextBox18.Text, "東", TextCompare: false) == 0)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 6000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 6000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 12000.0);
		}
		else if (Operators.CompareString(TextBox18.Text, "南", TextCompare: false) == 0)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 3000.0);
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 5000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 8000.0);
		}
		else if (Operators.CompareString(TextBox18.Text, "西", TextCompare: false) == 0)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 3000.0);
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 5000.0);
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 8000.0);
		}
		MessageBox.Show("精算しました、そのまま対局を続行してください", "満貫が支払われました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		break;
	}
}

// Sanmate.Form1
using System;
using Microsoft.VisualBasic.CompilerServices;

private void Button15_Click(object sender, EventArgs e)
{
	PictureBox3.Visible = true;
	Button15.Visible = false;
	TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 1000.0);
	TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) + 1.0);
}

// Sanmate.Form1
using System;
using Microsoft.VisualBasic.CompilerServices;

private void Button14_Click(object sender, EventArgs e)
{
	PictureBox2.Visible = true;
	Button14.Visible = false;
	TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 1000.0);
	TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) + 1.0);
}

// Sanmate.Form1
using System;
using Microsoft.VisualBasic.CompilerServices;

private void Button16_Click(object sender, EventArgs e)
{
	PictureBox4.Visible = true;
	Button16.Visible = false;
	TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 1000.0);
	TextBox19.Text = Conversions.ToString(Conversions.ToDouble(TextBox19.Text) + 1.0);
}

// Sanmate.Form1
using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button17_Click(object sender, EventArgs e)
{
	if (CheckBox1.Checked & !CheckBox3.Checked & !CheckBox2.Checked)
	{
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 3000.0);
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 1500.0);
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 1500.0);
	}
	else if (CheckBox2.Checked & !CheckBox1.Checked & !CheckBox3.Checked)
	{
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 3000.0);
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 1500.0);
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 1500.0);
	}
	else if (CheckBox3.Checked & !CheckBox1.Checked & !CheckBox2.Checked)
	{
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 3000.0);
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 1500.0);
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 1500.0);
	}
	else if (!CheckBox1.Checked & CheckBox3.Checked & CheckBox2.Checked)
	{
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) - 3000.0);
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1500.0);
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1500.0);
	}
	else if (!CheckBox3.Checked & CheckBox1.Checked & CheckBox2.Checked)
	{
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) - 3000.0);
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1500.0);
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + 1500.0);
	}
	else if (!CheckBox2.Checked & CheckBox1.Checked & CheckBox3.Checked)
	{
		TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) - 3000.0);
		TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + 1500.0);
		TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + 1500.0);
	}
	CheckBox1.Visible = false;
	CheckBox3.Visible = false;
	CheckBox2.Visible = false;
	Label20.Visible = false;
	Button17.Visible = false;
	Button18.Visible = true;
	Interaction.MsgBox("処理を完了しました、連荘ボタンを押してください");
}

// Sanmate.Form1
using System;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

private void Button18_Click(object sender, EventArgs e)
{
	TextBox12.Text = Conversions.ToString(Conversions.ToDouble(TextBox12.Text) + 1.0);
	Button15.Visible = true;
	Button16.Visible = true;
	Button18.Visible = false;
	Button19.Visible = false;
	Button14.Visible = true;
	Label9.Text = "";
	if (Conversions.ToDouble(TextBox1.Text) < 0.0 || Conversions.ToDouble(TextBox2.Text) < 0.0 || Conversions.ToDouble(TextBox3.Text) < 0.0)
	{
		Button4.Visible = false;
		Button5.Visible = false;
		Button8.Visible = false;
		Button2.Visible = false;
		Button6.Visible = false;
		Button9.Visible = false;
		Button3.Visible = false;
		RadioButton4.Visible = false;
		RadioButton5.Visible = false;
		RadioButton6.Visible = false;
		Button10.Visible = false;
		Button11.Visible = false;
		Button12.Visible = false;
		Button13.Visible = false;
		Button14.Visible = false;
		Button15.Visible = false;
		Button16.Visible = false;
		PictureBox1.Visible = false;
		GroupBox1.Visible = false;
		Label11.Visible = false;
		Label10.Visible = false;
		TextBox8.Visible = false;
		TextBox9.Visible = false;
		TextBox10.Visible = false;
		TextBox11.Visible = false;
		TextBox12.Visible = false;
		TextBox16.Visible = false;
		TextBox17.Visible = false;
		TextBox18.Visible = false;
		TextBox19.Visible = false;
		if (Operators.CompareString(TextBox1.Text, TextBox2.Text, TextCompare: false) == 0 == Conversions.ToBoolean(TextBox3.Text))
		{
			if (RadioButton1.Checked)
			{
				Label14.Text = Conversions.ToString(1);
				Label6.Text = Conversions.ToString(3);
				Label13.Text = Conversions.ToString(2);
			}
			if (RadioButton2.Checked)
			{
				Label14.Text = Conversions.ToString(2);
				Label6.Text = Conversions.ToString(1);
				Label13.Text = Conversions.ToString(3);
			}
			if (RadioButton3.Checked)
			{
				Label14.Text = Conversions.ToString(3);
				Label6.Text = Conversions.ToString(2);
				Label13.Text = Conversions.ToString(1);
			}
		}
		else if (Operators.CompareString(TextBox1.Text, TextBox2.Text, TextCompare: false) == 0)
		{
			if (Operators.CompareString(TextBox1.Text, TextBox3.Text, TextCompare: false) < 0)
			{
				Label13.Text = Conversions.ToString(1);
				if (RadioButton1.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label6.Text = Conversions.ToString(3);
				}
				else if (RadioButton2.Checked)
				{
					Label14.Text = Conversions.ToString(3);
					Label6.Text = Conversions.ToString(2);
				}
				else if (RadioButton3.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label6.Text = Conversions.ToString(3);
				}
			}
			else if (Operators.CompareString(TextBox1.Text, TextBox3.Text, TextCompare: false) > 0)
			{
				Label13.Text = Conversions.ToString(3);
				if (RadioButton1.Checked)
				{
					Label14.Text = Conversions.ToString(1);
					Label6.Text = Conversions.ToString(2);
				}
				else if (RadioButton2.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label6.Text = Conversions.ToString(1);
				}
				else if (RadioButton3.Checked)
				{
					Label14.Text = Conversions.ToString(1);
					Label6.Text = Conversions.ToString(2);
				}
			}
		}
		else if (Operators.CompareString(TextBox2.Text, TextBox3.Text, TextCompare: false) == 0)
		{
			if (Operators.CompareString(TextBox2.Text, TextBox1.Text, TextCompare: false) < 0)
			{
				Label13.Text = Conversions.ToString(1);
				if (RadioButton1.Checked)
				{
					Label6.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(3);
				}
				else if (RadioButton2.Checked)
				{
					Label6.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(3);
				}
				else if (RadioButton3.Checked)
				{
					Label6.Text = Conversions.ToString(3);
					Label13.Text = Conversions.ToString(2);
				}
			}
			else if (Operators.CompareString(TextBox2.Text, TextBox1.Text, TextCompare: false) > 0)
			{
				Label13.Text = Conversions.ToString(3);
				if (RadioButton1.Checked)
				{
					Label6.Text = Conversions.ToString(1);
					Label13.Text = Conversions.ToString(2);
				}
				else if (RadioButton2.Checked)
				{
					Label6.Text = Conversions.ToString(1);
					Label13.Text = Conversions.ToString(2);
				}
				else if (RadioButton3.Checked)
				{
					Label6.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(1);
				}
			}
		}
		else if (Operators.CompareString(TextBox1.Text, TextBox3.Text, TextCompare: false) == 0)
		{
			if (Operators.CompareString(TextBox1.Text, TextBox2.Text, TextCompare: false) < 0)
			{
				Label6.Text = Conversions.ToString(1);
				if (RadioButton1.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(3);
				}
				else if (RadioButton2.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(3);
				}
				else if (RadioButton3.Checked)
				{
					Label14.Text = Conversions.ToString(3);
					Label13.Text = Conversions.ToString(2);
				}
			}
			else if (Operators.CompareString(TextBox1.Text, TextBox2.Text, TextCompare: false) > 0)
			{
				Label6.Text = Conversions.ToString(3);
				if (RadioButton1.Checked)
				{
					Label14.Text = Conversions.ToString(1);
					Label13.Text = Conversions.ToString(2);
				}
				else if (RadioButton2.Checked)
				{
					Label14.Text = Conversions.ToString(1);
					Label13.Text = Conversions.ToString(2);
				}
				else if (RadioButton3.Checked)
				{
					Label14.Text = Conversions.ToString(2);
					Label13.Text = Conversions.ToString(1);
				}
			}
		}
		Label12.Visible = true;
		Label18.Visible = true;
		Label19.Visible = true;
		Label14.Visible = true;
		Label6.Visible = true;
		Label13.Visible = true;
		int num = checked((int)Math.Round(Conversions.ToDouble(TextBox19.Text) * 1000.0));
		if (Conversions.ToDouble(Label14.Text) == 1.0)
		{
			TextBox1.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) + (double)num);
		}
		else if (Conversions.ToDouble(Label6.Text) == 1.0)
		{
			TextBox2.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) + (double)num);
		}
		else if (Conversions.ToDouble(Label13.Text) == 1.0)
		{
			TextBox3.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) + (double)num);
		}
		if (Conversions.ToDouble(Label14.Text) == 1.0)
		{
			Label12.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) / 1000.0 + 20.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label14.Text) == 2.0)
		{
			Label12.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) / 1000.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label14.Text) == 3.0)
		{
			Label12.Text = Conversions.ToString(Conversions.ToDouble(TextBox1.Text) / 1000.0 - 20.0 - 40.0);
		}
		if (Conversions.ToDouble(Label12.Text) < 0.0)
		{
			Label12.ForeColor = Color.Aqua;
		}
		else
		{
			Label12.ForeColor = Color.Fuchsia;
		}
		if (Conversions.ToDouble(Label6.Text) == 1.0)
		{
			Label18.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) / 1000.0 + 20.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label6.Text) == 2.0)
		{
			Label18.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) / 1000.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label6.Text) == 3.0)
		{
			Label18.Text = Conversions.ToString(Conversions.ToDouble(TextBox2.Text) / 1000.0 - 20.0 - 40.0);
		}
		if (Conversions.ToDouble(Label18.Text) < 0.0)
		{
			Label18.ForeColor = Color.Aqua;
		}
		else
		{
			Label18.ForeColor = Color.Fuchsia;
		}
		if (Conversions.ToDouble(Label13.Text) == 1.0)
		{
			Label19.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) / 1000.0 + 20.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label13.Text) == 2.0)
		{
			Label19.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) / 1000.0 - 40.0);
		}
		else if (Conversions.ToDouble(Label13.Text) == 3.0)
		{
			Label19.Text = Conversions.ToString(Conversions.ToDouble(TextBox3.Text) / 1000.0 - 20.0 - 40.0);
		}
		if (Conversions.ToDouble(Label19.Text) < 0.0)
		{
			Label19.ForeColor = Color.Aqua;
		}
		else
		{
			Label19.ForeColor = Color.Fuchsia;
		}
		Label15.Visible = true;
		Label16.Visible = true;
		Label17.Visible = true;
		Label12.Visible = true;
		Label18.Visible = true;
		Label19.Visible = true;
		Label15.Visible = true;
		Label16.Visible = true;
		Label17.Visible = true;
		Label14.Visible = true;
		Label6.Visible = true;
		Label13.Visible = true;
		Label12.Visible = true;
		Label18.Visible = true;
		Label19.Visible = true;
		Label14.Visible = true;
		Label6.Visible = true;
		Label13.Visible = true;
		Label15.Visible = true;
		Label16.Visible = true;
		Label17.Visible = true;
		TextBox8.Visible = false;
		TextBox9.Visible = false;
		TextBox10.Visible = false;
		TextBox11.Visible = false;
		TextBox12.Visible = false;
		TextBox16.Visible = false;
		TextBox17.Visible = false;
		TextBox18.Visible = false;
		TextBox19.Visible = false;
		Interaction.MsgBox("対局終了");
		Button7.Visible = true;
	}
	else
	{
		Interaction.MsgBox("連荘になります");
		if (Conversions.ToDouble(TextBox1.Text) > 1000.0)
		{
			Button14.Visible = true;
		}
		else
		{
			Button14.Visible = false;
		}
		if (Conversions.ToDouble(TextBox2.Text) > 1000.0)
		{
			Button15.Visible = true;
		}
		else
		{
			Button15.Visible = false;
		}
		if (Conversions.ToDouble(TextBox3.Text) > 1000.0)
		{
			Button16.Visible = true;
		}
		else
		{
			Button16.Visible = false;
		}
	}
}
