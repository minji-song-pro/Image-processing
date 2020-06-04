using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 영상처리소프트웨어
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        byte[,] inImage, outImage;
        int inH, inW, outH, outW;
        string filename = "";
        Bitmap paper;
        //////////////////////////////////////////
        ////공통함수
        /////////////////////////////////////////
        private void OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "raw"; //raw파일만 보여라
            ofd.Filter = "RAW File(*.raw) | *.raw"; //raw파일만 보여라
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                //파일 ---> 메모리
                //1. .raw파일 크기 알아내기
                long fSize = new FileInfo(filename).Length;
                // ** 중요 ** --> 영상크기 및 메모리 할당
                inH = inW = (int)Math.Sqrt(fSize); //실수를 정수로 캐스팅. //**중요**// //정방형일경우//
                //2. 2차원 배열 준비
                inImage = new byte[inH, inW];
                //파일 --> 배열로 값을 로딩하기
                BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open));
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        inImage[i, k] = br.ReadByte();
                    }
                }
                br.Close();
                Equal();
            }
        }
        
        private void SaveImage()
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.DefaultExt = "raw";
            sdf.Filter = "RAW File(*.raw) | *.raw";
            if (sdf.ShowDialog() == DialogResult.OK)
            {
                string saveFname = sdf.FileName;
                BinaryWriter bw = new BinaryWriter(File.Open(saveFname, FileMode.CreateNew));
                for (int i = 0; i < outH; i++)
                {
                    for (int k = 0; k < outW; k++)
                    {
                        bw.Write(outImage[i, k]);
                    }
                }
                bw.Close();
                MessageBox.Show(saveFname + "저장됨");
            }
        }

        private void DisplayImage()
        {
            paper = new Bitmap(outH, outW);
            //Form 및 PictureBox 크기 조절  //영상의 크기에 따라서 picturebox와 window 크기에 따라 변경
            this.Size = new Size(outW + 170, outH + 90); //+는 경험치
            //pictureBox1.Location{ 0; 0; }
            pictureBox1.Size = new Size(outH, outW);
            //크기 조절됨

            //색칠
            Color c;
            int r, g, b;
            for (int i = 0; i < outH; i++)
            {
                for (int k = 0; k < outW; k++)
                {
                    r = g = b = outImage[i, k];
                    c = Color.FromArgb(r, g, b);
                    paper.SetPixel(k, i, c);
                }

            }
            pictureBox1.Image = paper; // 액자에 사진끼워넣기
            //상태바 출력
            toolStripStatusLabel1.Text = "영상크기: " + outH + "x" + outW;
        }

        private double GetDoubleValue() //sub폼 숫자 가져오기
        {
            double retValue = 0.0;
            Sub_Input1 dlg = new Sub_Input1();
            if (dlg.ShowDialog(this) == DialogResult.OK)  //this--> main폼에 sub폼을 띄워라.
            {
                retValue = (double)dlg.numeric_double1.Value; //numeric 자동완성하려면 속성에서 Public으로 바꿔야함.
            }
            return retValue;
        }

        private int[] GetRangeValue() //sub폼 숫자 가져오기
        {
            int[] ary = new int[2];
            Sub_Input2 dlg = new Sub_Input2();
            if (dlg.ShowDialog(this) == DialogResult.OK)  //this--> main폼에 sub폼을 띄워라.
            {
                ary[0] = (int)dlg.numeric_start.Value; //numeric 자동완성하려면 속성에서 Public으로 바꿔야함.
                ary[1] = (int)dlg.numeric_end.Value;
            }
            return ary;
        }

        private bool CheckOpen()
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return false; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            return true;
        }

    //////////////////////////////////////////
    ////메뉴 선택 시 실행되는 이벤트 함수
    /////////////////////////////////////////

    private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
        private void 영상처리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 어둡게하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Darken();
        }
        private void 밝게하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bright();
        }
        private void 동일이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equal();
        }
        private void 반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reverse();
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 흑백ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void 흑백평균ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Black_Avg();
        }
        private void 상하대칭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void 좌우대칭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MirrorLR();
        }
        private void 도회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void 감마변환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamma();
        }
        private void 파라볼라변환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParabolaCap();
        }
        private void 파라볼라변환CupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParabolaCup();
        }
        private void 곱하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mul();
        }
        private void 나누기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Div();
        }
        private void 범위처리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Range();
        }
        private void 흑백중위수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void 상하대칭ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MirrorUD();
        }
        private void 화면이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Move_Screen();
        }
        private void 화면축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void 일반축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom_Out();
        }
        private void 일반확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom_In();
        }
        private void 백워딩확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom_In_Back();
        }
        private void 좌우대칭ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MirrorLR();
        }
        private void 기본회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate_Basic();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void 회전ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rotate_Basic();
        }
        private void 도회전ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void 회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void capToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParabolaCap();
        }
        private void cupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParabolaCup();
        }
        private void 밝게하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bright();
        }
        private void 어둡게하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Darken();
        }
        private void 곱하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mul();
        }
        private void 나누기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Div();
        }
        private void 흑백기본ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Black();
        }
        private void 흑백평균ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Black_Avg();
        }
        private void 흑백중위수ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BW_Mid();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void 엠보싱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embossing();
        }
        private void 블러링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blurr();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void 기본회전2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate_Basic2();
        }
        //////////////////////////////////////////
        ////*** 영상 처리 알고리즘 함수 ***
        /////////////////////////////////////////

        //동일영상 알고리즘
        private void Equal() 
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH; outW = inW;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        outImage[i, k] = inImage[i, k];
                    }
                }
                DisplayImage();
            }
        }

        private void Bright() //영상 덧셈 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
               toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int value = (int)GetDoubleValue(); //숫자입력받기
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] + value > 255)
                        outImage[i, k] = 255;
                    else if (inImage[i, k] + value < 0)
                        outImage[i, k] = 0;
                    else
                    outImage[i, k] = (byte)(inImage[i, k] + value);
                }

            }
            DisplayImage();
        }
        
        private void Darken() //영상 뺄셈 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int value = (int)GetDoubleValue(); //숫자입력받기
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] - value > 255)
                        outImage[i, k] = 255;
                    else if (inImage[i, k] - value < 0)
                        outImage[i, k] = 0;
                    else
                        outImage[i, k] = (byte)(inImage[i, k] - value);
                }
            }
            DisplayImage();
        }

        private void Mul() //영상 곱셈 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int value = (int)GetDoubleValue(); //숫자입력받기
            
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] * value > 255)
                        outImage[i, k] = 255;
                    else if (inImage[i, k] * value < 0)
                        outImage[i, k] = 0;
                    else
                        outImage[i, k] = (byte)(inImage[i, k] * value);
                }
            }
            DisplayImage();
        }
        
        private void Div() //영상 나눗셈 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int value = (int)GetDoubleValue(); //숫자입력받기
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] / value > 255)
                        outImage[i, k] = 255;
                    else if (inImage[i, k] / value < 0)
                        outImage[i, k] = 0;
                    else
                        outImage[i, k] = (byte)(inImage[i, k] / value);
                }
            }
            DisplayImage();
        }
        
        private void Reverse() //영상 반전 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                   outImage[i, k] = (byte)(255 - inImage[i, k]);
                }
            }
            DisplayImage();
        }
        
        private void Black() //영상 흑백 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int value = (int)GetDoubleValue(); //숫자입력받기
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k]  > value)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            }
            DisplayImage();
        }

        private void Black_Avg() //영상 흑백(평균) 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            long hap = 0;
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    hap += inImage[i, k];
                }
            }
            double avg = (double)hap / (inH * inW);

            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] > avg)
                        outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            }
            DisplayImage();
        }

        private void Range() //영상 범위처리 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            int[] ary = GetRangeValue(); //숫자입력받기
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if (inImage[i, k] >= ary[0] && inImage[i, k] <= ary[1])
                        outImage[i, k] = 0;
                    else
                        outImage[i, k] = inImage[i, k];
                }
            }
            DisplayImage();
        }

        private void MirrorUD() //영상 상하반전 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    outImage[inH - i - 1, k] = inImage[i, k];
                }
            }
            DisplayImage();
        }
        
        private void MirrorLR() //영상 좌우반전 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, inW - k - 1] = inImage[i, k];
                }
            }
            DisplayImage();
        }

        private void Rotate90() //영상 90도회전 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input + 값)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    outImage[i,k] = inImage[inH-1-k,i];
                }
            }
            DisplayImage();
        }

        private void Gamma() //감마 변환 알고리즘
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = (Input)**(1/r)
            double r = GetDoubleValue();
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    double res = Math.Pow(inImage[i, k], (1.0 / r));
                    if (res > 255)
                        res = 255;
                    else if(res<0)
                            res = 0;
                    outImage[i, k] = (byte)res;
                }
            }
            DisplayImage();

        }

        private void ParabolaCap()
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = (byte)(255.0-255.0*(inImage[i, k]/128.0-1)* (inImage[i, k] / 128.0 - 1));
                }
            }
            DisplayImage();
        } //파라볼라(Cap)
        
        private void ParabolaCup()
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    outImage[i, k] = (byte)(255.0 * (inImage[i, k] / 128.0 - 1) * (inImage[i, k] / 128.0 - 1));
                }
            }
            DisplayImage();
        } ////파라볼라(Cup)
        
        private void BW_Mid() //흑백 알고리즘 - 중위수
        {
            if (filename.Length <= 0 || filename is null) //파일이 존재하지 않을 경우
            {
                toolStripStatusLabel1.Text = "파일을 먼저 열어야 합니다.";
                return; //또는 메세지박스 띄워도 됨(파일을 먼저 여세요). 사용자한테는 불편할 수도 있음.(status bar추천)
            }
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
            byte[] ary1 = new byte[inH*inW];
            int index = 0;
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    ary1[index++] = inImage[i, k];
                }
            }

            Array.Sort(ary1); //오름차순
            Array.Reverse(ary1); //내림차순

            int midValue = ary1[ary1.Length / 2];
            
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if(inImage[i,k] > midValue)
                    outImage[i, k] = 255;
                    else
                        outImage[i, k] = 0;
                }
            }
            DisplayImage();
        }
        
        private void Move_Screen() // 화면 이동 알고리즘
        {
            if (!CheckOpen())
                return;
            // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
            outH = inH; outW = inW;
            // 출력 영상 메모리 할당
            outImage = new byte[outH, outW];
            // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
            int xVal = (int)GetDoubleValue();
            int yVal = (int)GetDoubleValue();
            for (int i = 0; i < inH; i++)
            {
                for (int k = 0; k < inW; k++)
                {
                    if((0 <= i - xVal && i - xVal < inW) && (0 <= k - yVal && k - yVal < inH))
                    outImage[i-xVal, k-yVal] = inImage[i, k];
                }
            }
            DisplayImage();
        } 

        private void Zoom_Out() //화면 축소 알고리즘
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                int scale = (int)GetDoubleValue();
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH/scale; outW = inW / scale;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        if ((0 <= i / scale && i / scale < outW) && (0 <= k / scale && k / scale < outH))
                            outImage[i/scale, k/scale] = inImage[i, k];  //평균값으로 처리--> 깨짐 방지 방법 중 1
                    }
                }
                DisplayImage();
            }
        }

        private void Zoom_In() //화면 확대 알고리즘
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                int scale = (int)GetDoubleValue();
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH * scale; outW = inW * scale;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        if ((0 <= i * scale && i * scale < outW) && (0 <= k * scale && k * scale < outH))
                            outImage[i * scale, k * scale] = inImage[i, k];  //평균값으로 처리--> 깨짐 방지 방법 중 1
                    }
                }
                DisplayImage();
            }
        }
        
        private void Zoom_In_Back() //화면 확대 알고리즘 - 백워딩
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                int scale = (int)GetDoubleValue();
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH * scale; outW = inW * scale;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                for (int i = 0; i < outH; i++)
                {
                    for (int k = 0; k < outW; k++)
                    {
                        if ((0 <= i / scale && i / scale < inW) && (0 <= k / scale && k / scale < inH))
                            outImage[i, k] = inImage[i/scale, k / scale];
                    }
                }
                DisplayImage();
            }
        }
        
        private void Rotate_Basic() //기본 회전 알고리즘 - 원점을 기준으로 회전
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH; outW = inW;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                int angle = (int)GetDoubleValue(); 
                double r = angle * Math.PI / 180.0; //삼각함수는 라디안 값을 씀.
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        int newI = (int)(Math.Cos(r) * i + Math.Sin(r) * k);
                        int newK = (int)(-Math.Sin(r) * i + Math.Cos(r) * k);
                        if ((0 <= newI && newI < outW) && (0 <= newK && newK < outH))
                        outImage[newI, newK] = inImage[i, k];
                    }
                }
                DisplayImage();
            }
        }
        
        private void Rotate_Basic2() //기본 회전2 알고리즘 - 사진의 중심점을 기준으로 회전
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH; outW = inW;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                int angle = (int)GetDoubleValue();
                double r = angle * Math.PI / 180.0; //삼각함수는 라디안 값을 씀.
                int cy = inH / 2;
                int cx = inW / 2;

                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        int OldK = (int)(Math.Cos(r) *(i-cx) + Math.Sin(r) * (k-cy) + cx);
                        int OldI = (int)(-Math.Sin(r) * (i - cx) + Math.Cos(r) * (k - cy) + cy);
                        if ((0 <= OldI && OldI < outW) && (0 <= OldK && OldK < outH))
                            outImage[k,i] = inImage[OldI,OldK];
                    }
                }
                DisplayImage();
            }
        }


        private void Embossing() //엠보싱 알고리즘
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH; outW = inW;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                const int mSize = 3; //마스크 사이즈
                //마스크 정의
                double[,] mask = new double [mSize, mSize]
                {  {-1.0, 0.0, 0.0 },
                   { 0.0, 0.0, 0.0 },
                   { 0.0, 0.0, 1.0 }  };
                // 임시 입력, 임시 출력 메모리 할당
                double[,] tmpInImage = new double[inH + 2, inW + 2];
                double[,] tmpOutImage = new double[outH, outW];
                // 임시 입력을 127로 초기화
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        tmpInImage[i, k] = 127.0;
                    }
                }
                // 입력 --> 임시 입력
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        tmpInImage[i + 1, k + 1] = inImage[i, k];
                    }
                }
                //회선연산 처리
                double S = 0.0; //마스크 9개와 곱해서 더한 값
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        //한점에 대해서 마스크와 연산
                        for (int m = 0; m < mSize; m++)
                        {
                            for (int n = 0; n < mSize; n++)
                            {
                                S += mask[m, n] * tmpInImage[i + m, k + n];
                            }
                        }
                        tmpOutImage[i, k] = S;
                        S = 0.0;
                    }   
                }
                //마스크의 함계가 0이면 전체에 128을 더한다.
                for (int i = 0; i < outH; i++)
                {
                    for (int k = 0; k < outW; k++)
                    {
                        tmpOutImage[i, k] += 128;
                    }
                }
                // 임시출력 --> 출력
                for (int i = 0; i < outH; i++)
                {
                    for (int k = 0; k < outW; k++)
                    {
                        if (tmpOutImage[i, k] > 255)
                            outImage[i, k] = 255;
                        else if (outImage[i, k] < 0)
                            outImage[i, k] = 0;
                        else
                            outImage[i, k] = (byte)tmpOutImage[i, k];
                    }
                }
                DisplayImage();
            }
        }

        private void Blurr() //블러링 알고리즘
        {
            if (!CheckOpen())
            {
                return;
            }
            else
            {
                // (중요!) 출력 영상(output Image)의 크기 결정  --> 알고리즘에 따라 다름.
                outH = inH; outW = inW;
                // 출력 영상 메모리 할당
                outImage = new byte[outH, outW];
                // ***진짜 영상 처리 알고리즘 구현 *** (Output = Input)
                const int mSize = 3; //마스크 사이즈
                //마스크 정의
                double[,] mask = new double[mSize, mSize]
                {  { 1/9.0, 1/9.0, 1/9.0 },
                   { 1/9.0, 1/9.0, 1/9.0 },
                   { 1/9.0, 1/9.0, 1/9.0 }  };
                // 임시 입력, 임시 출력 메모리 할당
                double[,] tmpInImage = new double[inH + 2, inW + 2];
                double[,] tmpOutImage = new double[outH, outW];
                // 임시 입력을 127로 초기화
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        tmpInImage[i, k] = 127.0;
                    }
                }
                // 입력 --> 임시 입력
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        tmpInImage[i + 1, k + 1] = inImage[i, k];
                    }
                }
                //회선연산 처리
                double S = 0.0; //마스크 9개와 곱해서 더한 값
                for (int i = 0; i < inH; i++)
                {
                    for (int k = 0; k < inW; k++)
                    {
                        //한점에 대해서 마스크와 연산
                        for (int m = 0; m < mSize; m++)
                        {
                            for (int n = 0; n < mSize; n++)
                            {
                                S += mask[m, n] * tmpInImage[i + m, k + n];
                            }
                        }
                        tmpOutImage[i, k] = S;
                        S = 0.0;
                    }
                }
                // 임시출력 --> 출력
                for (int i = 0; i < outH; i++)
                {
                    for (int k = 0; k < outW; k++)
                    {
                        if (tmpOutImage[i, k] > 255)
                            outImage[i, k] = 255;
                        else if (outImage[i, k] < 0)
                            outImage[i, k] = 0;
                        else
                            outImage[i, k] = (byte)tmpOutImage[i, k];
                    }
                }
                DisplayImage();
            }
        } 
    }
}
