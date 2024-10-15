using System.Text;
using System.Xml;
using DTO_QL_SinhVien;

namespace DAL_QL_SinhVien
{
    public class StudentDAL
    {
        List<StudentDTO> lstStudent = new List<StudentDTO>();

        public List<StudentDTO> LstStudent { get => lstStudent; set => lstStudent = value; }
        public List<StudentDTO> readFile (string fileName)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            try
            {
                XmlDocument read = new XmlDocument();
                read.Load(fileName);
                XmlNodeList nodeList = read.SelectNodes("StudentList/Student");
                foreach (XmlNode node in nodeList)
                {
                    StudentDTO st = new StudentDTO();
                    st.StudentID = node["StudentID"].InnerText;
                    st.Firstname = node["FirstName"].InnerText;
                    st.Lastname = node["LastName"].InnerText;
                    st.Email = node["Email"].InnerText;
                    st.Phone = node["Phone"].InnerText;
                    st.AverageScore = double.Parse(node["AverageScore"].InnerText);
                    lstStudent.Add(st);
                }
                return lstStudent;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
