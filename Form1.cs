namespace Exammination3
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();
        public Form1()
        {
            InitializeComponent();
            LoadAdvisors();
            UpdateStudentList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("Dr.Pyothorn", "Computer Science"));
            advisors.Add(new Advisor("Dr.Wullapa", "Mathematics"));
            advisors.Add(new Advisor("Dr.Noppakun", "Computer Science"));
            advisors.Add(new Advisor("Dr.Patareeya", "Mathematics"));
            advisors.Add(new Advisor("Dr.Bongla", "Mathematics"));
            advisors.Add(new Advisor("Dr.Chantogo", "Computer Science"));
            advisors.Add(new Advisor("Dr.KhamNongDon", "Computer Science"));

            cmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void btnAddstudent_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string name = tbName.Text;
            string major = tbMajor.Text;
            double grade;

            if (!double.TryParse(tbGrade.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                return;
            }

            if (cmbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                return;
            }
            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lbID.Text = student.ID;
            lbName.Text = student.Name;
            lbMajor.Text = student.Major;
            lbGrade.Text = student.Grade.ToString();
            lbAdvisor.Text = student.Advisor.Name;

            UpdateStudentList();
            MessageBox.Show("เพิ่มข้อมูลนักศึกษาเรียบร้อยแล้ว!");
        }

        private void btnShowStuent_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("ยังไม่มีนักศึกษาที่ถูกบันทึก");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุด: {topStudent.Name} (เกรด: {topStudent.Grade})");
        }

        private void UpdateStudentList()
        {
            lstStudent.Items.Clear();
            foreach (var student in students)
            {
                lstStudent.Items.Add(student.Name);
            }
        }

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstStudent.SelectedIndex != -1)
            {

                string selectedName = lstStudent.SelectedItem.ToString();


                Student student = students.FirstOrDefault(s => s.Name == selectedName);


                if (student != null)
                {
                    lbID.Text = student.ID;
                    lbName.Text = student.Name;
                    lbMajor.Text = student.Major;
                    lbGrade.Text = student.Grade.ToString();
                    lbAdvisor.Text = student.Advisor.Name;
                }
            }


        }

        private void btnShowAll_Click(object sender, EventArgs e)
            {
                if (cmbAdvisor.SelectedItem == null)
                {
                    MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                    return;
                }

                string advisorName = cmbAdvisor.SelectedItem.ToString();
                Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

                MessageBox.Show($"นักศึกษาในที่ปรึกษาของ {advisor.Name}: {advisor.GetStudentList()}");
            }
        }
    }

