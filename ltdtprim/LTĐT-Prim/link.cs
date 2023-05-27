using System;
using System.Drawing;

namespace algorithmass
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Serializable]
	public class link
	{
		public link(long d,string f,string t)
		{
			distance=d;
			from=f;
			to=t;
			// 
			// TODO: Add constructor logic here
			//
		}
		public link()
		{
			
			// 
			// TODO: Add constructor logic here
			//
		}
		Pen pen = new Pen(Color.BlueViolet,3);
		SolidBrush brush = new SolidBrush(Color.Red);
		
		public long distance;
		public string from;
		public string to;
		//Font font = new Font("new roman",9);
		public void setcenter(Point p)
		{
			Point s = new Point();
			s.X=p.X+10;
			s.Y=p.Y+10;
			Center1=s;
		}
		public void setcenter1(Point p)
		{
			Point s = new Point();
			s.X=p.X+10;
			s.Y=p.Y+10;
			Center2=s;
		}
		public void drawline()
		{
			Point p1=new Point();
			Point p2=new Point();
			p1.X=Center1.X;
			p1.Y=Center1.Y;
			p2.X=Center2.X;
			p2.Y=Center2.Y;
			//
			/*Point K1=new Point();
			Point K2= new Point();
			K1.X=p1.X+10;
			K2.Y=p2.Y+10;*/

			Graphics g = algorithmass.Form1.K.CreateGraphics();
			g.DrawLine(pen,p1,p2);
			//g.DrawString(distance.ToString(),font,brush,K1.X,K2.Y);
		}
		public Point Center1,Center2;
	}
}
