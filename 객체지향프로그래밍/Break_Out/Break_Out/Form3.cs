using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Out
{
	public partial class Form3 : Form
	{
		//실행하는 폼의 크기, 벽돌의 크기, 플레이어 크기, 공의 크기
		//공의 기울기, 공,라켓,벽돌 모양, 벽돌 개수
		//설정값이 변동되지 않는 변수들은 상수처리 해준다.
		const int form_W = 700;
		const int form_H = 500;
		const int block_W = 70;
		const int block_H = 20;
		const int player_W = 90;
		const int player_H = 10;
		const int ball_W = 10;
		const int ball_H = 10;
		const int block_Y = 70;
		const int player_Y = 455;

		//벽돌 배열선언
		Rectangle[] block = new Rectangle[100];
		bool[] block_Visible = new bool[100];

		// 그려줘야할 객체들 선언
		Graphics g;
		Rectangle player;
		Rectangle ball;

		//현재 점수, 최고 점수
		int score = 0;
		static int highscore = 0;

		double slope;
		int dir = 1;
		int max_Block = 100;
		int block_Removed = 0;
		int first_Block = 20;
		int death_Count = 0;
		Timer t = new Timer();
		Random r = new Random();

		public Form3()
		{
			InitializeComponent();
			InitializeComponent();
			this.Text = "5533401_안종현";
			this.ClientSize = new Size(form_W, form_H);             //프로그램 실행 시 폼의 크기를 변경해준다.

			Start_Game();
			t.Interval = 100;
			t.Tick += timer1_Tick;
		}

		private void Start_Game()
		{
			Create_Ball();
			Create_Player();
			Block_Visible();
			Start_Ball();
			Block_Visible();

			t.Start();
			// blocks[] 을 초기화
			for (int i = 0; i < first_Block; i++)
				block[i] = new Rectangle(i % 10 * block_W,
				  block_Y + i / 10 * block_H, block_W, block_H);
		}

		private void Block_Visible()
		{
			for (int i = 0; i < first_Block; i++)
				block_Visible[i] = true;
		}

		//게임 시작 시 플레이어가 생성되는 초기 위치
		private void Create_Player()
		{
			player = new Rectangle(form_W / 2 - player_W / 2, player_Y, player_W, player_H);        //아래 주석처리된 코드를 뭉쳐 쓰면 이렇게 표현 가능
			//player.X = form_W / 2 - player_W / 2;													//폼의 x축 중심 - 플레이어의 중심 = 중앙
			//player.Y = player.Y;																	//Y축은 위에서 값을 지정해 주었으므로 그대로 선언해준다.	
			//player.Width = player_W;																
			//player.Height = player_H;
		}

		//게임 시작 시 공이 생성되는 초기 위치
		private void Create_Ball()
		{
			ball = new Rectangle(form_W / 2 - ball_W / 2, player_Y - 10, ball_W, ball_H);           //처음 공이 생성될 때는 플레이어의 바로 위로 생성된다.
		}

		//플레이어와 공을 그려주는 메서드 
		private void Draw_Ball()
		{
			g.FillRectangle(Brushes.YellowGreen, ball);
			g.DrawRectangle(new Pen(Color.Black), ball);
		}

		private void Draw_player()
		{
			g.FillRectangle(Brushes.MediumPurple, player);
			g.DrawRectangle(new Pen(Color.Black), player);
		}

		private void Start_Ball()                   //공의 이동 메서드 slope라는 변수에 값을 랜덤으로 주어 대각선 방향으로 이동하게 만듬
		{
			slope = r.Next(5, 20) / 10.0;			//NEXT(m,M) 최소값~최대값 범위까지 랜덤으로 생성하지만 정수로하면 값이 너무 커서 10을 나누어 실수형으로 변환
			if (r.Next(2) % 2 == 1)					//NEXT안에는 int형인 정수형밖에 들어가지 못함으로 위와 같이 구현하였음
				slope = -slope;
		}

		//벽돌을 일정한 간격을 두고 그려주는 메서드
		private void Draw_Blocks()
		{
			for (int i = 0; i < first_Block; i++)
				if (block_Visible[i] == true)
				{
					g.FillRectangle(Brushes.LightSlateGray, i % 10 * block_W, block_Y + i / 10 * block_H, block_W - 1, block_H - 1);
					//g.DrawRectangle(new Pen(Color.Black), i % 10 * block_W, block_Y + i / 10 * block_H, block_W - 1, block_H - 1);
					//벽돌의 테두리까지 그리니 틱마다 그려지는게 너무 선명해져서 번쩍거림이 심하여 주석처리
				}
		}
					

		protected override void OnPaint(PaintEventArgs e)
		{
			g = e.Graphics;
			Draw_player();
			Draw_Ball();
			Draw_Blocks();
			Font font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
			g.DrawString("SCORE : " + score.ToString(), font, Brushes.MediumPurple, new PointF(10, 20));
			g.DrawString("STAGE : " + (first_Block / 20).ToString(), font, Brushes.MediumPurple, new PointF(300, 20));
			g.DrawString("HIGH SCORE : " + highscore.ToString(), font, Brushes.MediumPurple, new PointF(560, 20));
			g.DrawString("DEATH : " + death_Count.ToString(), font, Brushes.MediumPurple, new PointF(10, 470));
		}

		//플레이어 조작법: 좌우 화살표로 움직이며 화면 끝애 닿으면 더 이상 이동 불가
		private void Form3_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				player.X -= 20;
				if (player.X < 0)
				{
					player.X = -10;							//교차판정이 까다로워서 x가 0에서 멈췄을때 공도 x=0좌표로 날아갈 시
															//관통하고 떨어지는 것을 방지하기 위하여 -10까지만 허용
				}
			}
			else if (e.KeyCode == Keys.Right)
			{
				player.X += 20;
				if (player.X > form_W - player_W)
				{
					player.X = form_W - player_W;
				}
			}
			Invalidate();
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			Graphics g;
			g = this.CreateGraphics();
			ball.X += (int)(10 * slope);
			if (ball.X < 0 || ball.X + ball_W > form_W)                     // 좌우 화면 끝에 공이 닿으면 튕겨나가도록 체크
			{
				slope = -slope;
			}
			ball.Y += dir * 10;

			// ball이 천장이나 라켓에 맞았는지 체크
			if (ball.Y < 0 || player.IntersectsWith(ball))                  //사각형이 교차되었는지 확인하여 방향을 전환해줌
			{
				dir = -dir;
			}

			Invalidate();

			// ball이 화면 아래보다 더 내려갔다면, 라켓으로 받아내지 못한 것이므로 죽은 것
			if (ball.Y > form_H)
			{
				ball.X = form_W / 2 - ball_W / 2;       //공의 포지션을 다시 잡아준다.
				ball.Y = block_Y + 8 * block_H;         //부활 할때는 화면의 중앙에서 생성되게 정해준다.
				death_Count++;                          //공을 떨어뜨릴때 마다 카운트를 추가한다.
				Start_Ball();

				//공을 3번 떨어뜨리면 게임이 종료 된다.
				if (death_Count >= 3)
				{
					t.Stop();
					string str = string.Format("3번 공을 떨어뜨려 게임이 종료됩니다.", first_Block / 20);
					DialogResult result = MessageBox.Show(str, "게임 오버!", MessageBoxButtons.OK);
					this.Close();
				}
			}

			// 블록의 맨 아래 위치보다 볼이 더 아래에 있다면 블록과의 intersect를 비교하지 않는다
			if (ball.Y > block_Y + block_H * first_Block / 10)
				return;

			for (int i = 0; i < first_Block; i++)
			{
				if (block_Visible[i] && ball.IntersectsWith(block[i]))
				{
					block_Visible[i] = false;
					score += 10;
					if (highscore < score) //최대 스코어보다 스코어가 크면
					{
						highscore = highscore + 10; //최대스코어 갱신
					}
					dir = -dir;
					if (++block_Removed >= first_Block)
					{
						timer1.Stop();

						if (first_Block == max_Block)
						{
							MessageBox.Show("최종 스테이지 클리어!", "게임 클리어!", MessageBoxButtons.OK);
							this.Close();
						}
						else
						{
							t.Stop();
							string str = string.Format("스테이지 {0} 클리어! 다음 스테이지로 가시겠습니까?", first_Block / 20);
							DialogResult result = MessageBox.Show(str, "스테이지 클리어!", MessageBoxButtons.YesNo);
							if (result == DialogResult.Yes)
								Next_Stage();
							else
								Close();
						}
					}
				}
			}
		}
		private void Next_Stage()
		{
			if (first_Block > max_Block)
				return; // nBlocks = MaxBlocks;

			first_Block += 20;  // 20개 씩 증가

			Start_Game();

			block_Removed = 0;
		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			t.Dispose();
		}
	}
}
