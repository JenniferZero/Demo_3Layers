using DTO_QL_SinhVien;
using DAL_QL_SinhVien;
using System.Diagnostics.Contracts;

namespace BLL_QL_SinhVien
{
    public class StudentBLL
    {   
        StudentDAL studentDAL = new StudentDAL();
        public StudentBLL() { }
        public List<StudentDTO> getStudentList()
        {
            return studentDAL.readFile("../../Data/StudentList.xml");
        }
    }
}
