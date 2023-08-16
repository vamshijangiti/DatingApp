namespace API;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByNameAsync(string userName);
    Task<MemberDto> GetMemberAsync(string userName);
    Task<IEnumerable<MemberDto>> GetMembersAsync();

}
