using System.Text;
using BLL_QL_SinhVien;
using DTO_QL_SinhVien;

namespace GUI_QL_SinhVien
{
    public class StudentGUI
    {
        StudentBLL studentBLL = new StudentBLL();
        public void showStudentList()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            try
            {
                Console.WriteLine("\t\t\t\t\t\tSTUDENT LIST");
                string kq = "StudentID\tFull name \t\t\tPhone\t\tE-mail\t\t\tAverage Score";
                Console.WriteLine(kq);

                List<StudentDTO> lstStudent = new List<StudentDTO>();
                lstStudent = studentBLL.getStudentList();
                foreach (StudentDTO st in lstStudent)
                {
                    Console.WriteLine(st.toString());
                }
            }
            catch (Exception e) { }
        }
    }
}
