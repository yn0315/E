using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPProject
{
    public partial class Form4 : Form
    {
        Form frn;
        Form1 frm1;

        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 152;
        const int MIN_SLIDING_WIDTH = 10;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 1;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 152;
        int LineLimitSizea = 30;// 발주 텍스트박스 최대길이 

        public Form4()
        {
            InitializeComponent();
            IniEvent();
            textBox45.Text = DateTime.Now.ToString("yy.MM.dd"); //발주등록
            textBox80.Text = DateTime.Now.ToString("yy.MM.dd"); //입고등록
            textBox99.Text = DateTime.Now.ToString("yy.MM.dd"); //지급관리 텍스트
            textBox133.Text = DateTime.Now.ToString("yy.MM.dd"); //수리등록

        }
        private void IniEvent()
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Gradient);
            this.uiPanel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Gradient);
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Gradient);
        }

        public void Form_Gradient(object sender, PaintEventArgs e)
        {
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, Color.DarkTurquoise, Color.DarkTurquoise, 0, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
        private void Panel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = System.Drawing.ColorTranslator.FromHtml("#e0c3fc");
            Color middleColor = System.Drawing.ColorTranslator.FromHtml("#8ec5fc");
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, System.Drawing.Color.Black, System.Drawing.Color.Black, 0, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
        private void panel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = System.Drawing.ColorTranslator.FromHtml("#e0c3fc");
            Color middlecolor = System.Drawing.ColorTranslator.FromHtml("#8ec5fc");
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, System.Drawing.Color.Black, System.Drawing.Color.Black, 0, false);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 2f, 1 };
            cb.Colors = new[] { startColor, middlecolor, endColor };

            br.InterpolationColors = cb;
            br.RotateTransform(45);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frn.Visible = true;
            this.Close();
            //로그아웃버튼
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            //가맹점별 현황 버튼
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //가맹점별 현황 그리드뷰
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //가맹점별 현황 검색텍스트
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //가맹점별 현황 확인버튼
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //가맹점별 현황 삭제버튼
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //가맹점별 현황 수정버튼
            panel6.BringToFront();
            panel6.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //가맹점별 현황 수정 그리드뷰
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Visible= false;
            //가맹점별 현황 그리드뷰 안에 수정 버튼
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //창고별 현황 검색 텍스트 버튼
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //창고별 현황 검색 확인 버튼
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //창고별 현황 그리드 뷰
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //창고별 현황 삭제 버튼
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //창고별 현황 수정 버튼
            panel11.BringToFront();
            panel11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //창고별 현황 확인 버튼
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
            //왼쪽 창고별 현황 버튼
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //창고별현황 수정 팝업 안에 몇번창고인지 텍스트파일
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //창고별현황 수정 팝업 그리드뷰
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //창고별현황 수정 팝업 주소 텍스트박스
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel11.Visible= false;
            //창고별현황 수정 팝업 수정 버튼
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별수불현황 그리드뷰
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //월별 수불현황 검색 텍스트뷰
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //월별수불현황 검색 확인 버튼
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //월별수불현황 삭제버튼
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //월별 수불현황 수정 버튼
            panel16.BringToFront();
            panel16.Visible = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //월별수불현황 확인버튼
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel13.BringToFront();
            //왼쪽 월별수불현황 버튼
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별 수불현황 수정 팝업 그리드뷰
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel16.Visible= false;
            //월별 수불현황 수정 팝업 수정버튼
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //왼쪽발주신청버튼
            panel19.BringToFront();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //발주신청 품목명 텍스트박스
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            //발주신청 품목번호 텍스트박스
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //발주신청 담당자 명 텍스트박스
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //발주신청 가맹점 텍스트박스
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //발주신청 확인 버튼 //
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            //발주신청서 입력 텍스트박스
            string strTemp = textBox23.Text;

            string[] arrTemp = strTemp.Split('\r','\n');

            if (arrTemp[arrTemp.Length - 1].Length >= LineLimitSizea) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }
            
            textBox23.Text = strTemp;
            textBox23.Select(textBox23.Text.Length, 0); //offset 이동
            textBox23.Focus();

            
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //발주 현황 그리드뷰
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            //발주현황 검색텍스트박스
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //발주현황 검색 확인버튼
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //발주현황 확인버튼
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //발주 현황 등록버튼
            panel30.BringToFront();
            panel30.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel23.BringToFront();
            //왼쪽 발주 현황 버튼
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //발주현황 팝업창 안에 등록 버튼
            panel30.Visible = false;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            //품목명 텍스트박스
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            //담당자 이름 텍스트박스
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            //거래회사 텍스트박스
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            //품목번호 텍스트박스
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            //신청가맹점 텍스트박스
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            //연락처 텍스트박스
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //발주현황 팝업 안에 내용 텍스트박스
            int a = 25;
            string strTemp = textBox43.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox43.Text = strTemp;
            textBox43.Select(textBox43.Text.Length, 0); //offset 이동
            textBox43.Focus();
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            //발주현황 날짜 자동 텍스트 입력 하게 해바 싀발
            //textBox45.Text = DateTime.Now.ToString("yy.MM.dd");
            //DateTime.Now.ToString("yy.MM.dd");
            
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            //발주현황 팝업 담당자 이름 텍스트박스
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel33.BringToFront();
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            int a = 35;
            string strTemp = textBox63.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox63.Text = strTemp;
            textBox63.Select(textBox63.Text.Length, 0); //offset 이동
            textBox63.Focus();
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 텍스트박스
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 배송담당자 텍박 
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 창고명 텍박
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 연락처 텍박
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 품목명 텍박
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //입고등록 가맹점 수량 텍박
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //입고현황 그리드뷰
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            //입고현황 검색 텍박
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //입고현황 검색 확인버튼
        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 품목명 텍스트
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 품목번호 텍스트
        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 담당자
        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 창고명
        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 배송담당
        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            //입고등록 팝업 연락처
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel50.BringToFront();
            panel50.Visible = true;
            //입고현황 등록버튼
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //입고등록 팝업 등록버튼
            panel50.Visible = false;
        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            //발주날짜
        }

        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            //입고현황 팝업 담당자 이름
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel37.BringToFront();
            //왼쪽 입고현황 버튼
        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //지급관리 조회 그리드뷰
        }

        private void textBox116_TextChanged(object sender, EventArgs e)
        {
            //지급관리조회 검색텍스트박스
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //지급관리조회 검색 확인버튼
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel53.BringToFront();
            panel53.Visible = true;
            //지급관리조회 등록 버튼
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel53.Visible = false;
            //지급관리 팝업 수정 등록
        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {
            int a = 35;
            string strTemp = textBox101.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox101.Text = strTemp;
            textBox101.Select(textBox101.Text.Length, 0); //offset 이동
            textBox101.Focus();
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 품목명
        }

        private void textBox104_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 품목번호
        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 담당자
        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 창고명
        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 배송담당
        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {
            //지급관리 팝업 연락처
        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel60.BringToFront();
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 품목명
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 담당자
        }

        private void textBox120_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 품목번호
        }

        private void textBox119_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 가맹점
        }

        private void textBox118_TextChanged(object sender, EventArgs e)
        {
            int a = 35;
            string strTemp = textBox118.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox118.Text = strTemp;
            textBox118.Select(textBox118.Text.Length, 0); //offset 이동
            textBox118.Focus();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //수리입고등록 등록버튼
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //수리입고등록 확인버튼
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel56.BringToFront();
            //왼쪽 지급관리조회버튼
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //수리입고현황 버튼
            panel64.BringToFront();
        }

        private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //수리입고현황 그리드뷰
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            //수리입고현황 텍스트
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //수리입고현황 텍스트 확인
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //수리입고현황 등록버튼
            panel67.Visible = true;
            panel67.BringToFront();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            //수리입고현황 확인버튼
        }

        private void textBox135_TextChanged(object sender, EventArgs e)
        {
            int a = 25;
            string strTemp = textBox135.Text;

            string[] arrTemp = strTemp.Split('\r', '\n');

            if (arrTemp[arrTemp.Length - 1].Length >= a) //전역변수 : 10 , 최대길이 10
            {
                strTemp += Environment.NewLine;
            }

            textBox135.Text = strTemp;
            textBox135.Select(textBox135.Text.Length, 0); //offset 이동
            textBox135.Focus();
        }

        private void textBox133_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 품목명
        }

        private void textBox140_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 담당자
        }

        private void textBox138_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 품목번호
        }

        private void textBox137_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 창고명
        }

        private void textBox139_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 거래회사
        }

        private void textBox136_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 연락처
        }

        private void textBox130_TextChanged(object sender, EventArgs e)
        {
            //수리입고등록 담당자이름
        }

        private void button55_Click(object sender, EventArgs e)
        {
            panel67.Visible = false;
            //수리입고등록 등록버튼
        }

        private void textBox150_TextChanged(object sender, EventArgs e)
        {
            //수리수불현황 검색 텍스트
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //수리수불현황 검색 확인
        }

        private void dataGridView18_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //수리수불현황 그리드뷰
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel70.BringToFront();
            //수리수불현황 왼쪽 버튼
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //수리수불현황 확인버튼
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel73.BringToFront();
            //왼쪽 재고 관리 버튼
        }
    }
}
