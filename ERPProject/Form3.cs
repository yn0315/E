using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPProject
{
    public partial class Form3 : Form
    {
        Form frn;
        
        static Form frma;

        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 152;
        const int MIN_SLIDING_WIDTH = 10;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 1;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 152;
        public Form3()
        {
            InitializeComponent();


        }
        public void setX(object name)
        {
            frma= (Form)name;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel12.Visible= true;
            panel12.BringToFront();
            // 보고서 분기별 등록 버튼
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // 재무별 보고서 분기별 차트 그래프
        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 재무 보고서 분기별 그리드뷰
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 월별 매입 확인
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            // 월별 매입 그래프
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            // 보고서 검색 칸
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //보고서 검색 확인 칸
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 보고서 분기별 그리드뷰
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 보고서 분기별 수정버튼
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel12.Visible= false;
            
            // 분기별 보고서 작성 후 등록 버튼
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 제목 텍스트 박스
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 담당자 텍스트 박스
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 내용 텍스트 박스
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // 분기별 보고서 담당자 직급 입력칸
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 작성 일자 입력칸
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //분기별 보고서 분기 입력칸
        }

        private void button67_Click(object sender, EventArgs e)
        {
            panel36.Visible= true;
            panel36.BringToFront();
            // 분기별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //월별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //년별 보고서 그리드뷰로 들어가는 버튼
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel15.Visible= true;
            panel15.BringToFront();
            // 보고서에서 월별 보고서로 들어가는 버튼
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            // 월별 보고서 검색 창
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // 월별 보고서 검색 창 확인버튼
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //월별 보고서 수정 버튼
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel16.Visible= true;
            panel16.BringToFront();
            //월별 보고서 등록 버튼
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별 보고서 그리드뷰
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 제목 입력칸
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 담당자 입력칸
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 직급 입력칸
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 작성일자 등록칸
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //월별 보고서 기간 입력칸
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            // 월별 보고서 내용 입력칸
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel16.Visible= false;
            //월별보고서 작성 내용 등록버튼
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            // 년별보고서 제목 입력칸
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            // 년별 보고서 담당자 입력칸
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            //년별보고서 작성 일자 입력칸
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            //년별 보고서 직급 입력칸
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
           //년별 보고서 년도 입력칸
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            // 년별 보고서 내용 입력칸
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel11.Visible= false;
            // 년별 보고서 작성 등록 버튼
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel10.Visible= true;
            panel10.BringToFront();
            //년별 보고서로 들어가는 버튼
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {
            //분기별보고서
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //월별보고서
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //년별 보고서

        }

        private void button33_Click(object sender, EventArgs e)
        {
            //집계표 패널로 들어가는 버튼
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            //월별 집계표 날자 검색 첫번째 칸
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            //월별 집계표 날자 검색 두번째 칸
        }

        private void button35_Click(object sender, EventArgs e)
        {
            // 월별 집계표 날자 검색 검색버튼
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //월별 집계표 그리드뷰
        }

        private void textBox43_TextChanged_1(object sender, EventArgs e)
        {
            // 사원 전체 연봉 검색창
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //사원 전체 연봉 검색 확인버튼
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //사원 전체 연봉 그리드뷰
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // 사원 전체 연봉 수정 버튼
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //사원 전체 연봉 확인버튼
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            //사원 전체 연봉
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel18.Visible= true;
            panel18.BringToFront();
            // 사원 전체 연봉으로 들어가는 버튼
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            //자금계획표 날자 왼쪽 칸 검색책
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            //자금계획표 날자 오른쪽 칸 검색책
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            //자금계획표 날짜 검색 버튼
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //자금계획표 그리드뷰
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 제목
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 담당자
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 작성일자
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 예상금액
        }

        private void textBox45_TextChanged_1(object sender, EventArgs e)
        {
            //자금계획서 실행일자
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            //자금계획서 내용입력칸
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel24.Visible= false;
            //자금계획서 작성 내용 등록 칸
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 자금계획서 수정버튼
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel24.Visible= true;
            panel24.BringToFront();
            //자금계획서 등록버튼
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel21.Visible= true;
            panel21.BringToFront();
            //자금계획표로 들어가는 버튼
        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            //지출 날짜 왼쪽 창 입력
        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            //지출 날짜 오른쪽 창 입력
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //지출 검색창 확인 버튼
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //지출 그리드뷰
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //지출 확인버튼
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 담당자입력칸
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 작성 일자 입력칸
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 총 지출 금액 입력칸
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //지출 내역서 실행 날자 입력칸
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel27.Visible= false;
            //지출 내역서 작성 등록
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel26.Visible= true;
            panel26.BringToFront();
            //지출로 들어가는 버튼
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel28.Visible= true;
            panel28.BringToFront();
            //수입으로 들어가는 버튼
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            //수입 날짜 왼쪽 창 입력
        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            //수입 날짜 오른쪽 창 입력
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //수입 검책창 확인
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 수입 그리드뷰
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            //수입내역서 담당자 입력칸
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            //수입 내역서 작성 날자 입력칸
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            //수입내역서 총 수입 입력칸
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            // 수입내역서 실행날짜
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //수입 내역서 내용 그리드뷰
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            //지출
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //지출 내역서 그리드뷰
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel31.Visible= false;
            //수입내역서 작성 등록버튼
        }

        private void button41_Click(object sender, EventArgs e)
        {
            // 수입내역서 수정 버튼
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel31.Visible= true;
            panel31.BringToFront();
            //수입내역서 등록버튼
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            //수입
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel34.Visible= true;
            panel34.BringToFront();
            //직원경조사로 들어가는 버튼
        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            //직원 경조사
        }

        private void textBox98_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 날자 왼쪽 검색칸  
        }

        private void textBox96_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 날짜 오른쪽 검색칸
        }

        private void button47_Click(object sender, EventArgs e)
        {
            // 직원 경조사 날짜 검색 확인버튼
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //직원 경조사 그리드뷰
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //직원 경조사 수정
        }

        private void button48_Click(object sender, EventArgs e)
        {
            panel35.Visible= true;
            panel35.BringToFront();
            //직원 경조사 등록
        }

        private void textBox88_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 관련 서류 사원번호
        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            // 직원 경조사 관련 서류 사원명
        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 관련 서류 종류
        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 작성일자
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {
            //직원 경조사 내용 입력칸
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel35.Visible= false;
            //직원 경조사 내용 등록
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel40.Visible= true;
            panel40.BringToFront();
            //일용직 급여 들어가는 버튼
        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여 검색창
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //일용직 급여 검색창 확인 버튼
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //일용직 급여 그리드뷰
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //일용직 급여 수정버튼
        }

        private void button52_Click(object sender, EventArgs e)
        {
            panel41.Visible= true;
            panel41.BringToFront();
            //일용직 급여 확인버튼
        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 일한 지역/부서
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //일용직 급여의 캘린더
        }

        private void textBox103_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 이름
        }

        private void textBox101_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 전화번호
        }

        private void textBox107_TextChanged(object sender, EventArgs e)
        {
            //일용직 급여확인창의 계좌
        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel41.Visible= false;
            //일용직 급여 확인창의 확인버튼
        }

        private void button53_Click(object sender, EventArgs e)
        {
            // 일용직 급여 삭제버튼
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {
            //일용직 급여
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel42.Visible= true;
            panel42.BringToFront();
            //퇴직급여로 들어가는 창
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            //퇴직급여 검색창
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //퇴직급여 검색 확인창
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //퇴직급여 그리드뷰
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //퇴직급여 수정버튼
        }

        private void button58_Click(object sender, EventArgs e)
        {
            panel45.Visible= true;
            panel45.BringToFront();
            //퇴직 급여 확인버튼
        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {
            //퇴직급여창
        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원번호
        }

        private void textBox100_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원명
        }

        private void textBox117_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 부서명
        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 사원직책
        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 입사일
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 퇴사일
        }

        private void textBox127_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 근무기간
        }

        private void textBox129_TextChanged(object sender, EventArgs e)
        {
            //퇴직 급여 관리의 퇴직금액
        }

        private void button54_Click(object sender, EventArgs e)
        {
            panel45.Visible= false;
            
            //퇴직 급여 관리 내용 확인버튼
            
        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {
            //퇴직급여 관리
        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {
            //일용직 급여 확인창
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            // 직원 경조사 관련 서류
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            //수입내역 등록
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            //지출 내역 창
        }

        private void button39_Click(object sender, EventArgs e)
        {
            // 지출 등록 창
            panel27.Visible= true;
            panel27.BringToFront();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            //자금계획표
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            //자금계획서
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            // 년 별 보고서창
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel11.Visible= true;
            panel11.BringToFront();
            //년별 보고서 등록
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //년별 보고서 수정
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //월별 보고서 등록 창
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel36.Visible= true;
            panel36.BringToFront();
            // 보고서 창으로 들어가는 버튼
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //분기별 보고서
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding1.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding1.Stop();
            }

            panel14.Height = _posSliding;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                panel14.Size = new Size(152, 6);
                checkBox2.Location = new Point(x: 3, y: 121);
                panel15.Location = new Point(x: 3, y: 151);

                if(checkBox2.Checked == true)
                {
                    panel15.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 164);
                    panel16.Location = new Point(x: 3, y: 193);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 205);
                        panel4.Location = new Point(x: 3, y:234);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 254);
                        panel4.Location = new Point(x: 3, y: 283);
                    }
                }
                else
                {
                    panel15.Size = new Size(152, 116);
                    checkBox3.Location = new Point(x: 3, y: 275);
                    panel16.Location = new Point(x: 3, y:304);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 314);
                        panel4.Location = new Point(x: 3, y: 343);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 367);
                        panel4.Location = new Point(x: 3, y: 396);
                    }
                }
            }
            else
            {
                panel14.Size = new Size(152, 120);
                checkBox2.Location = new Point(x: 3, y: 232);
                panel15.Location = new Point(x: 3, y: 262);

                if(checkBox2.Checked == true)
                {
                    panel15.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 274);
                    panel16.Location = new Point(x: 3, y: 303);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 315);
                        panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 362);
                        panel4.Location = new Point(x: 3, y: 391);
                    }
                }
                else
                {
                    panel15.Size = new Size(152, 116);
                    checkBox3.Location = new Point(x: 3, y: 385);
                    panel16.Location = new Point(x: 3, y: 414);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 426);
                        panel4.Location = new Point(x: 3, y: 455);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 481);
                        panel4.Location = new Point(x: 3, y: 511);
                    }    
                }
            }
            timerSliding1.Start();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                panel15.Size = new Size(152, 6);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y: 164);
                    panel16.Location = new Point(x: 3, y: 193);
                    
                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 205);
                        panel4.Location = new Point(x: 3, y: 234);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 254);
                        panel4.Location = new Point(x: 3, y: 283);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox3.Location = new Point(x: 3, y: 274);
                    panel16.Location = new Point(x: 3, y: 303);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 315);
                        panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 362);
                        panel4.Location = new Point(x: 3, y: 391);
                    }
                }
            }
            else
            {
                panel15.Size = new Size(152, 116);
                if(checkBox1.Checked== true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox3.Location = new Point(x: 3, y:275);
                    panel16.Location = new Point(x: 3, y: 304);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 314);
                        panel4.Location = new Point(x: 3, y: 343);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 367);
                        panel4.Location = new Point(x: 3, y: 396);
                    }
                }
                else
                {
                    panel14.Size = new Size(150, 120);
                    checkBox3.Location = new Point(x: 3, y: 385);
                    panel16.Location = new Point(x: 3, y: 414);

                    if(checkBox3.Checked == true)
                    {
                        panel16.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 426);
                        panel4.Location = new Point(x: 3, y: 455);
                    }
                    else
                    {
                        panel16.Size = new Size(152, 53);
                        checkBox4.Location = new Point(x: 3, y: 481);
                        panel4.Location = new Point(x: 3, y: 511);
                    }
                }
            }
            timerSliding2.Start();
        }
        private void timerSliding2_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding2.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding2.Stop();
            }

            panel15.Height = _posSliding;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                panel16.Size = new Size(152, 6);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 205);
                        panel4.Location = new Point(x: 3, y: 234);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox4.Location = new Point(x: 3, y: 314);
                        panel4.Location = new Point(x: 3, y: 343);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);
                    
                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 315);
                        panel4.Location = new Point(x: 3, y: 344);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox4.Location = new Point(x: 3, y: 426);
                        panel4.Location = new Point(x: 3, y: 455);
                    }
                }
            }
            else
            {
                panel16.Size = new Size(152, 53);
                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 254);
                        panel4.Location = new Point(x: 3, y: 283);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox4.Location = new Point(x: 3, y: 367);
                        panel4.Location = new Point(x: 3, y: 396);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox4.Location = new Point(x: 3, y: 362);
                        panel4.Location = new Point(x: 3, y: 391);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox4.Location = new Point(x: 3, y: 481);
                        panel4.Location = new Point(x: 3, y: 511);
                    }
                }
            }
            timerSliding3.Start();
        }
        private void timerSliding3_Tick(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding3.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding3.Stop();
            }

            panel16.Height = _posSliding;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                panel4.Size = new Size(152, 6);

                if(checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox3.Location = new Point(x: 3, y: 164);
                        panel16.Location = new Point(x: 3, y: 193);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox3.Location = new Point(x: 3, y: 275);
                        panel16.Location = new Point(x: 3, y: 304);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);

                    if(checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox3.Location = new Point(x: 3, y: 274);
                        panel16.Location = new Point(x: 3, y: 303);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox3.Location = new Point(x: 3, y: 385);
                        panel16.Location = new Point(x: 3, y: 414);
                    }

                }

            }
            else
            {
                panel14.Size = new Size(152, 48);

                if (checkBox1.Checked == true)
                {
                    panel14.Size = new Size(152, 6);
                    checkBox2.Location = new Point(x: 3, y: 121);
                    panel15.Location = new Point(x: 3, y: 151);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox3.Location = new Point(x: 3, y: 164);
                        panel16.Location = new Point(x: 3, y: 193);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox3.Location = new Point(x: 3, y: 275);
                        panel16.Location = new Point(x: 3, y: 304);
                    }
                }
                else
                {
                    panel14.Size = new Size(152, 120);
                    checkBox2.Location = new Point(x: 3, y: 232);
                    panel15.Location = new Point(x: 3, y: 262);

                    if (checkBox2.Checked == true)
                    {
                        panel15.Size = new Size(152, 6);
                        checkBox3.Location = new Point(x: 3, y: 274);
                        panel16.Location = new Point(x: 3, y: 303);
                    }
                    else
                    {
                        panel15.Size = new Size(152, 116);
                        checkBox3.Location = new Point(x: 3, y: 385);
                        panel16.Location = new Point(x: 3, y: 414);
                    }
                }
            }
            timerSliding4.Start();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            frma.Visible = true;
            this.Visible = false;
        }

        private void timerSliding4_Tick(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding4.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding4.Stop();
            }

            panel4.Height = _posSliding;
        }
    }
}
