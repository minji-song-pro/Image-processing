namespace 영상처리소프트웨어
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.동일이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.범위처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.감마변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기하학처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상하대칭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.상하대칭ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.좌우대칭ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.일반축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평균값축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중위수축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일반확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.백워딩확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.양선형보간법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.중앙회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파라볼라변환ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.명암ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.밝게하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.어둡게하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.곱하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.나누기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백기본ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백평균ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.흑백중위수ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.화소영역처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엠보싱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기본회전2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.영상처리ToolStripMenuItem,
            this.기하학처리ToolStripMenuItem,
            this.화소영역처리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 영상처리ToolStripMenuItem
            // 
            this.영상처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동일이미지ToolStripMenuItem,
            this.명암ToolStripMenuItem,
            this.반전ToolStripMenuItem,
            this.흑백ToolStripMenuItem,
            this.범위처리ToolStripMenuItem,
            this.감마변환ToolStripMenuItem,
            this.파라볼라변환ToolStripMenuItem1});
            this.영상처리ToolStripMenuItem.Name = "영상처리ToolStripMenuItem";
            this.영상처리ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.영상처리ToolStripMenuItem.Text = "화소점 처리";
            this.영상처리ToolStripMenuItem.Click += new System.EventHandler(this.영상처리ToolStripMenuItem_Click);
            // 
            // 동일이미지ToolStripMenuItem
            // 
            this.동일이미지ToolStripMenuItem.Name = "동일이미지ToolStripMenuItem";
            this.동일이미지ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.동일이미지ToolStripMenuItem.Text = "동일 이미지";
            this.동일이미지ToolStripMenuItem.Click += new System.EventHandler(this.동일이미지ToolStripMenuItem_Click);
            // 
            // 반전ToolStripMenuItem
            // 
            this.반전ToolStripMenuItem.Name = "반전ToolStripMenuItem";
            this.반전ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.반전ToolStripMenuItem.Text = "반전";
            this.반전ToolStripMenuItem.Click += new System.EventHandler(this.반전ToolStripMenuItem_Click);
            // 
            // 흑백ToolStripMenuItem
            // 
            this.흑백ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.흑백기본ToolStripMenuItem,
            this.흑백평균ToolStripMenuItem1,
            this.흑백중위수ToolStripMenuItem1});
            this.흑백ToolStripMenuItem.Name = "흑백ToolStripMenuItem";
            this.흑백ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.흑백ToolStripMenuItem.Text = "흑백";
            this.흑백ToolStripMenuItem.Click += new System.EventHandler(this.흑백ToolStripMenuItem_Click);
            // 
            // 범위처리ToolStripMenuItem
            // 
            this.범위처리ToolStripMenuItem.Name = "범위처리ToolStripMenuItem";
            this.범위처리ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.범위처리ToolStripMenuItem.Text = "범위처리";
            this.범위처리ToolStripMenuItem.Click += new System.EventHandler(this.범위처리ToolStripMenuItem_Click);
            // 
            // 감마변환ToolStripMenuItem
            // 
            this.감마변환ToolStripMenuItem.Name = "감마변환ToolStripMenuItem";
            this.감마변환ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.감마변환ToolStripMenuItem.Text = "감마 변환";
            this.감마변환ToolStripMenuItem.Click += new System.EventHandler(this.감마변환ToolStripMenuItem_Click);
            // 
            // 기하학처리ToolStripMenuItem
            // 
            this.기하학처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상하대칭ToolStripMenuItem,
            this.회전ToolStripMenuItem,
            this.화면이동ToolStripMenuItem,
            this.화면축소ToolStripMenuItem,
            this.화면확대ToolStripMenuItem});
            this.기하학처리ToolStripMenuItem.Name = "기하학처리ToolStripMenuItem";
            this.기하학처리ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.기하학처리ToolStripMenuItem.Text = "기하학 처리";
            // 
            // 상하대칭ToolStripMenuItem
            // 
            this.상하대칭ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상하대칭ToolStripMenuItem1,
            this.좌우대칭ToolStripMenuItem1});
            this.상하대칭ToolStripMenuItem.Name = "상하대칭ToolStripMenuItem";
            this.상하대칭ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.상하대칭ToolStripMenuItem.Text = "대칭";
            this.상하대칭ToolStripMenuItem.Click += new System.EventHandler(this.상하대칭ToolStripMenuItem_Click);
            // 
            // 화면이동ToolStripMenuItem
            // 
            this.화면이동ToolStripMenuItem.Name = "화면이동ToolStripMenuItem";
            this.화면이동ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.화면이동ToolStripMenuItem.Text = "화면 이동";
            this.화면이동ToolStripMenuItem.Click += new System.EventHandler(this.화면이동ToolStripMenuItem_Click);
            // 
            // 화면축소ToolStripMenuItem
            // 
            this.화면축소ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일반축소ToolStripMenuItem,
            this.평균값축소ToolStripMenuItem,
            this.중위수축소ToolStripMenuItem});
            this.화면축소ToolStripMenuItem.Name = "화면축소ToolStripMenuItem";
            this.화면축소ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.화면축소ToolStripMenuItem.Text = "화면 축소";
            this.화면축소ToolStripMenuItem.Click += new System.EventHandler(this.화면축소ToolStripMenuItem_Click);
            // 
            // 화면확대ToolStripMenuItem
            // 
            this.화면확대ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일반확대ToolStripMenuItem,
            this.백워딩확대ToolStripMenuItem,
            this.양선형보간법ToolStripMenuItem});
            this.화면확대ToolStripMenuItem.Name = "화면확대ToolStripMenuItem";
            this.화면확대ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.화면확대ToolStripMenuItem.Text = "화면 확대";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 248);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // 상하대칭ToolStripMenuItem1
            // 
            this.상하대칭ToolStripMenuItem1.Name = "상하대칭ToolStripMenuItem1";
            this.상하대칭ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.상하대칭ToolStripMenuItem1.Text = "상하 대칭";
            this.상하대칭ToolStripMenuItem1.Click += new System.EventHandler(this.상하대칭ToolStripMenuItem1_Click);
            // 
            // 좌우대칭ToolStripMenuItem1
            // 
            this.좌우대칭ToolStripMenuItem1.Name = "좌우대칭ToolStripMenuItem1";
            this.좌우대칭ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.좌우대칭ToolStripMenuItem1.Text = "좌우 대칭";
            this.좌우대칭ToolStripMenuItem1.Click += new System.EventHandler(this.좌우대칭ToolStripMenuItem1_Click);
            // 
            // 일반축소ToolStripMenuItem
            // 
            this.일반축소ToolStripMenuItem.Name = "일반축소ToolStripMenuItem";
            this.일반축소ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.일반축소ToolStripMenuItem.Text = "일반 축소";
            this.일반축소ToolStripMenuItem.Click += new System.EventHandler(this.일반축소ToolStripMenuItem_Click);
            // 
            // 평균값축소ToolStripMenuItem
            // 
            this.평균값축소ToolStripMenuItem.Enabled = false;
            this.평균값축소ToolStripMenuItem.Name = "평균값축소ToolStripMenuItem";
            this.평균값축소ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.평균값축소ToolStripMenuItem.Text = "평균값 축소";
            // 
            // 중위수축소ToolStripMenuItem
            // 
            this.중위수축소ToolStripMenuItem.Enabled = false;
            this.중위수축소ToolStripMenuItem.Name = "중위수축소ToolStripMenuItem";
            this.중위수축소ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.중위수축소ToolStripMenuItem.Text = "중위수 축소";
            // 
            // 일반확대ToolStripMenuItem
            // 
            this.일반확대ToolStripMenuItem.Name = "일반확대ToolStripMenuItem";
            this.일반확대ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.일반확대ToolStripMenuItem.Text = "일반 확대";
            this.일반확대ToolStripMenuItem.Click += new System.EventHandler(this.일반확대ToolStripMenuItem_Click);
            // 
            // 백워딩확대ToolStripMenuItem
            // 
            this.백워딩확대ToolStripMenuItem.Name = "백워딩확대ToolStripMenuItem";
            this.백워딩확대ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.백워딩확대ToolStripMenuItem.Text = "백워딩 확대";
            this.백워딩확대ToolStripMenuItem.Click += new System.EventHandler(this.백워딩확대ToolStripMenuItem_Click);
            // 
            // 양선형보간법ToolStripMenuItem
            // 
            this.양선형보간법ToolStripMenuItem.Enabled = false;
            this.양선형보간법ToolStripMenuItem.Name = "양선형보간법ToolStripMenuItem";
            this.양선형보간법ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.양선형보간법ToolStripMenuItem.Text = "양선형 보간법";
            // 
            // 회전ToolStripMenuItem
            // 
            this.회전ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회전ToolStripMenuItem1,
            this.기본회전2ToolStripMenuItem,
            this.중앙회전ToolStripMenuItem});
            this.회전ToolStripMenuItem.Name = "회전ToolStripMenuItem";
            this.회전ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회전ToolStripMenuItem.Text = "회전";
            this.회전ToolStripMenuItem.Click += new System.EventHandler(this.회전ToolStripMenuItem_Click);
            // 
            // 회전ToolStripMenuItem1
            // 
            this.회전ToolStripMenuItem1.Name = "회전ToolStripMenuItem1";
            this.회전ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.회전ToolStripMenuItem1.Text = "기본 회전(1)";
            this.회전ToolStripMenuItem1.Click += new System.EventHandler(this.회전ToolStripMenuItem1_Click);
            // 
            // 중앙회전ToolStripMenuItem
            // 
            this.중앙회전ToolStripMenuItem.Enabled = false;
            this.중앙회전ToolStripMenuItem.Name = "중앙회전ToolStripMenuItem";
            this.중앙회전ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.중앙회전ToolStripMenuItem.Text = "중앙 회전";
            // 
            // 파라볼라변환ToolStripMenuItem1
            // 
            this.파라볼라변환ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capToolStripMenuItem,
            this.cupToolStripMenuItem});
            this.파라볼라변환ToolStripMenuItem1.Name = "파라볼라변환ToolStripMenuItem1";
            this.파라볼라변환ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.파라볼라변환ToolStripMenuItem1.Text = "파라볼라 변환";
            // 
            // capToolStripMenuItem
            // 
            this.capToolStripMenuItem.Name = "capToolStripMenuItem";
            this.capToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.capToolStripMenuItem.Text = "Cap";
            this.capToolStripMenuItem.Click += new System.EventHandler(this.capToolStripMenuItem_Click);
            // 
            // cupToolStripMenuItem
            // 
            this.cupToolStripMenuItem.Name = "cupToolStripMenuItem";
            this.cupToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cupToolStripMenuItem.Text = "Cup";
            this.cupToolStripMenuItem.Click += new System.EventHandler(this.cupToolStripMenuItem_Click);
            // 
            // 명암ToolStripMenuItem
            // 
            this.명암ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.밝게하기ToolStripMenuItem1,
            this.곱하기ToolStripMenuItem1,
            this.어둡게하기ToolStripMenuItem1,
            this.나누기ToolStripMenuItem1});
            this.명암ToolStripMenuItem.Name = "명암ToolStripMenuItem";
            this.명암ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.명암ToolStripMenuItem.Text = "명암";
            // 
            // 밝게하기ToolStripMenuItem1
            // 
            this.밝게하기ToolStripMenuItem1.Name = "밝게하기ToolStripMenuItem1";
            this.밝게하기ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.밝게하기ToolStripMenuItem1.Text = "밝게하기";
            this.밝게하기ToolStripMenuItem1.Click += new System.EventHandler(this.밝게하기ToolStripMenuItem1_Click);
            // 
            // 어둡게하기ToolStripMenuItem1
            // 
            this.어둡게하기ToolStripMenuItem1.Name = "어둡게하기ToolStripMenuItem1";
            this.어둡게하기ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.어둡게하기ToolStripMenuItem1.Text = "어둡게하기";
            this.어둡게하기ToolStripMenuItem1.Click += new System.EventHandler(this.어둡게하기ToolStripMenuItem1_Click);
            // 
            // 곱하기ToolStripMenuItem1
            // 
            this.곱하기ToolStripMenuItem1.Name = "곱하기ToolStripMenuItem1";
            this.곱하기ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.곱하기ToolStripMenuItem1.Text = "곱하기";
            this.곱하기ToolStripMenuItem1.Click += new System.EventHandler(this.곱하기ToolStripMenuItem1_Click);
            // 
            // 나누기ToolStripMenuItem1
            // 
            this.나누기ToolStripMenuItem1.Name = "나누기ToolStripMenuItem1";
            this.나누기ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.나누기ToolStripMenuItem1.Text = "나누기";
            this.나누기ToolStripMenuItem1.Click += new System.EventHandler(this.나누기ToolStripMenuItem1_Click);
            // 
            // 흑백기본ToolStripMenuItem
            // 
            this.흑백기본ToolStripMenuItem.Name = "흑백기본ToolStripMenuItem";
            this.흑백기본ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.흑백기본ToolStripMenuItem.Text = "흑백(기본)";
            this.흑백기본ToolStripMenuItem.Click += new System.EventHandler(this.흑백기본ToolStripMenuItem_Click);
            // 
            // 흑백평균ToolStripMenuItem1
            // 
            this.흑백평균ToolStripMenuItem1.Name = "흑백평균ToolStripMenuItem1";
            this.흑백평균ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.흑백평균ToolStripMenuItem1.Text = "흑백(평균)";
            this.흑백평균ToolStripMenuItem1.Click += new System.EventHandler(this.흑백평균ToolStripMenuItem1_Click);
            // 
            // 흑백중위수ToolStripMenuItem1
            // 
            this.흑백중위수ToolStripMenuItem1.Name = "흑백중위수ToolStripMenuItem1";
            this.흑백중위수ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.흑백중위수ToolStripMenuItem1.Text = "흑백(중위수)";
            this.흑백중위수ToolStripMenuItem1.Click += new System.EventHandler(this.흑백중위수ToolStripMenuItem1_Click);
            // 
            // 화소영역처리ToolStripMenuItem
            // 
            this.화소영역처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엠보싱ToolStripMenuItem,
            this.블러링ToolStripMenuItem});
            this.화소영역처리ToolStripMenuItem.Name = "화소영역처리ToolStripMenuItem";
            this.화소영역처리ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.화소영역처리ToolStripMenuItem.Text = "화소영역처리";
            // 
            // 엠보싱ToolStripMenuItem
            // 
            this.엠보싱ToolStripMenuItem.Name = "엠보싱ToolStripMenuItem";
            this.엠보싱ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.엠보싱ToolStripMenuItem.Text = "엠보싱";
            this.엠보싱ToolStripMenuItem.Click += new System.EventHandler(this.엠보싱ToolStripMenuItem_Click);
            // 
            // 블러링ToolStripMenuItem
            // 
            this.블러링ToolStripMenuItem.Name = "블러링ToolStripMenuItem";
            this.블러링ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.블러링ToolStripMenuItem.Text = "블러링";
            this.블러링ToolStripMenuItem.Click += new System.EventHandler(this.블러링ToolStripMenuItem_Click);
            // 
            // 기본회전2ToolStripMenuItem
            // 
            this.기본회전2ToolStripMenuItem.Name = "기본회전2ToolStripMenuItem";
            this.기본회전2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.기본회전2ToolStripMenuItem.Text = "기본 회전(2)";
            this.기본회전2ToolStripMenuItem.Click += new System.EventHandler(this.기본회전2ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "영상처리 소프트웨어(Ver 0.02)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영상처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 동일이미지ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 감마변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기하학처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상하대칭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화면확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 범위처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상하대칭ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 좌우대칭ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 일반축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 평균값축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중위수축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일반확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 백워딩확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 양선형보간법ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 중앙회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파라볼라변환ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 명암ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 밝게하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 어둡게하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 곱하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 나누기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 흑백기본ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 흑백평균ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 흑백중위수ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 화소영역처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엠보싱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기본회전2ToolStripMenuItem;
    }
}

