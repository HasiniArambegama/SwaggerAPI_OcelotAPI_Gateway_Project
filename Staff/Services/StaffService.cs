using Staff.Data;

namespace Staff.Services
{
    public class StaffService : IStaffService
    {
        public List<Models.Staff> GetStaffs()
        {
            return StaffMockDataService.Staffs;
        }

        public Models.Staff? GetStaff(int id)
        {
            return StaffMockDataService.Staffs.FirstOrDefault(x => x.Id == id);
        }

        public Models.Staff? AddStaff(Models.Staff staff)
        {
            StaffMockDataService.Staffs.Add(staff);
            return staff;
        }

        public Models.Staff? UpdateStaff(Models.Staff staff)
        {
            Models.Staff? selectedStaff = StaffMockDataService.Staffs.FirstOrDefault(x => x.Id == staff.Id);
            if (selectedStaff != null)
            {
                selectedStaff.StudyArea = staff.StudyArea;
                selectedStaff.Position = staff.Position;
                selectedStaff.Address = staff.Address;
                selectedStaff.Age = staff.Age;
                selectedStaff.Name = staff.Name;
                return selectedStaff;
            }

            return selectedStaff;
        }

        public bool? DeleteStaff(int id)
        {
            Models.Staff? selectedStaff = StaffMockDataService.Staffs.FirstOrDefault(x => x.Id == id);
            if (selectedStaff != null)
            {
                StaffMockDataService.Staffs.Remove(selectedStaff);
                return true;
            }
            return false;
        }
    }
}
