using System;
using System.Drawing;
using System.Collections;


namespace algorithmass
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Serializable]
	public class node
	{
		public string name;
		SolidBrush brush = new SolidBrush(Color.Black);
		public node()
		{			
		}
		public Point Center;
		Font font=new Font("new roman",9);
		public ArrayList ar=new ArrayList();
		public void setcenter(Point p)
		{
			Center = p;
		}
		public void drawc()
		{
			Graphics s = algorithmass.Form1.K.CreateGraphics();
			
			s.FillEllipse(brush,Center.X,Center.Y,30,30);
			s.DrawString(name,font,brush,Center.X,Center.Y+30);
		} 
		



	}
}
