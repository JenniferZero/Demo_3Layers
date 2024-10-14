using GUI_QL_SinhVien;

namespace GUI_QLSinhVien
{
    class Program
    {
        public static void testStudentList()
        {
            StudentGUI studentGUI = new StudentGUI();
            studentGUI.showStudentList();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            testStudentList();
        }
    }
}
