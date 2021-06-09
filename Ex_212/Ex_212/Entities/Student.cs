
namespace Ex_212.Entities {
    class Student {
        public int Code { get; set; }

        public Student(int code) {
            Code = code;
        }

        public override bool Equals(object obj) {
            if (!(obj is Student)) {
                return false;
            }
            Student other = obj as Student;
            return Code.Equals(other.Code);
        }

        public override int GetHashCode() {
            return Code.GetHashCode();
        }
    }
}
