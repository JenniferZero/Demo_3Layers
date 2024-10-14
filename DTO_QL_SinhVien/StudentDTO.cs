using System.ComponentModel.Design;

namespace DTO_QL_SinhVien
{
    public class StudentDTO
    {
        public string StudentID { get => _studentID; set => _studentID = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Email { get => _email; set => _email = value; }
        public double AverageScore { get => _averageScore; set => _averageScore = value; }

        private string _studentID;
        private string _firstname;
        private string _lastname;
        private string _phone;
        private string _email;
        private double _averageScore;

        public StudentDTO()
        {
            this.StudentID = "";
            this.Lastname = "";
            this.Firstname = "";
            this.Phone = "";
            this.Email = "";
            this.AverageScore = 0.0;    
        }
        public StudentDTO(string id, string fname, string lname, string phone, string email, double avgScore)
        {
            this.StudentID = id;
            this.Firstname = fname;
            this.Lastname = lname;
            this.Phone = phone;
            this.Email = email;
            this.AverageScore = avgScore;
        }
        public string toString() 
        {
            string kq = StudentID + "\t\t" + Lastname + "\t" + Firstname;
            if (Lastname.Length <= 15) {
                kq += "\t\t" + Phone;
            }
            else if(Lastname.Length <= 22)
            {
                kq += "\t" + Phone;
            }
            else
            {
                kq += Phone;
            }
            kq += "\t" + Email;
            if (Email.Length <= 15) {
                kq += "\t\t" + AverageScore;
            }
            else if (Email.Length <= 22)
            {
                kq += "\t" + AverageScore;
            }

            return kq;
        }
    }  
}
