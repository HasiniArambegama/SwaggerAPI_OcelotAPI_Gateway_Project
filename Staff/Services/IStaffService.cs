namespace Staff.Services
{
    public interface IStaffService
    {
        List<Models.Staff> GetStaffs();
        Models.Staff? GetStaff(int id);
        Models.Staff? AddStaff(Models.Staff staff);
        Models.Staff? UpdateStaff(Models.Staff staff);
        bool? DeleteStaff(int id);
    }
}
