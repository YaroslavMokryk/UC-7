using Xunit;

namespace UC_7.Tests
{
    public class StudentConverterTests
    {
        private StudentConverter converter = new StudentConverter();

        [Fact]
        public void ConvertStudents_HighAchiever_HonorRollIsTrue()
        {
            var students = new List<Student>
            {
                new Student { Name = "Alice", Age = 21, Grade = 91 }
            };

            var result = converter.ConvertStudents(students);

            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void ConvertStudents_ExceptionalYoungHighAchiever_ExceptionalIsTrue()
        {
            var students = new List<Student>
            {
                new Student { Name = "Bob", Age = 20, Grade = 91 }
            };

            var result = converter.ConvertStudents(students);

            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void ConvertStudents_PassedStudent_PassedIsTrue()
        {
            var students = new List<Student>
            {
                new Student { Name = "Charlie", Age = 22, Grade = 75 }
            };

            var result = converter.ConvertStudents(students);

            Assert.True(result[0].Passed);
        }

        [Fact]
        public void ConvertStudents_FailedStudent_PassedIsFalse()
        {
            var students = new List<Student>
            {
                new Student { Name = "Dave", Age = 23, Grade = 70 }
            };

            var result = converter.ConvertStudents(students);

            Assert.False(result[0].Passed);
        }

        [Fact]
        public void ConvertStudents_EmptyArray_ReturnsEmptyArray()
        {
            var students = new List<Student>();

            var result = converter.ConvertStudents(students);

            Assert.Empty(result);
        }

        [Fact]
        public void ConvertStudents_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<System.ArgumentNullException>(() => converter.ConvertStudents(null));
        }
    }
}
