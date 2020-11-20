using System;
namespace DataForm_CustomAppearance {
    class EmployeeRepository {
        public EmployeeInfo Get(int id) {
            return new EmployeeInfo {
                FirstName = "Steven",
                LastName = "Buchanan",
                PhotoPath = "Steven_Buchanan",
                Email = "steven.buchanan@dxdemo.com",
                Phone = "5556070691",
                Address = "351 S Hill St.",
                City = "Los Angeles",
                State = "CA",
                Zip = "90013",
                Department = DepartmentType.Engineering,
                Position = "Engineer",
                HiredAt = new DateTime(2017, 6, 2)
            };
        }
    }
}
