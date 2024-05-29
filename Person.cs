using System.ComponentModel.DataAnnotations;

namespace Exercise3
{
    public class Person
    {
        [Range(1, int.MaxValue, ErrorMessage = "Age must be greater than 0")]
        public int Age { get; private set; }

        [Required]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "FName must be between 2 and 10 characters")]
        public string FName { get; private set; }

        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "LName must be between 3 and 15 characters")]
        public string LName { get; private set; }

        [Range(1.0, double.MaxValue, ErrorMessage = "Height must be greater than or equal to 1.00")]
        public double Height { get; private set; }

        [Range(1.0, double.MaxValue, ErrorMessage = "Weight must be greater than or equal to 1.00")]
        public double Weight { get; private set; }

        public Person(
            string fName,
            string lName,
            int age = 1,
            double height = 1.0,
            double weight = 1.0
        )
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;

            Validate();
        }

        public void SetAge(int age) => Age = IsValidValue(nameof(Age), age) ? age : Age;

        public void SetHeight(double height) =>
            Height = IsValidValue(nameof(Height), height) ? height : Height;

        public void SetWeight(double weight) =>
            Weight = IsValidValue(nameof(Weight), weight) ? weight : Weight;

        private void Validate()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);
            if (!isValid)
                throw new ArgumentException(
                    string.Join("  |  ", results.Select(x => x.ErrorMessage))
                );
        }

        private bool IsValidValue(string name, object value)
        {
            var context = new ValidationContext(this) { MemberName = name };
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateProperty(value, context, results);
            if (!isValid)
                throw new ArgumentException(
                    string.Join("  |  ", results.Select(x => x.ErrorMessage))
                );
            return isValid;
        }
    }
}
