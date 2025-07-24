using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULazarusData.Models;

namespace ULazarusService.Services
{
    public class UserSeederService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserSeederService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task SeedPasswordsAsync() {
            var admin1 = await _userManager.FindByEmailAsync("wasim@ulazarus.be");
                if (admin1 != null && string.IsNullOrEmpty(admin1.PasswordHash))
            {
                await _userManager.RemovePasswordAsync(admin1); // just in case
                await _userManager.AddPasswordAsync(admin1, "Admin.Wasim@1");
            }

            var admin2 = await _userManager.FindByEmailAsync("claire@ulazarus.be");
            if (admin2 != null && string.IsNullOrEmpty(admin2.PasswordHash))
            {
                await _userManager.RemovePasswordAsync(admin2); // just in case
                await _userManager.AddPasswordAsync(admin2, "AdminP@ssword2");
            }

            var admin3 = await _userManager.FindByEmailAsync("jonas@ulazarus.be");
            if (admin3 != null && string.IsNullOrEmpty(admin3.PasswordHash))
            {
                await _userManager.RemovePasswordAsync(admin3); // just in case
                await _userManager.AddPasswordAsync(admin3, "AdminP@ssword3");
            }

            var teacherEmails = new Dictionary<string, string>
            {
                { "alice.jansen@ulazarus.be", "Teacher@Pass1" },
                { "bart.peeters@ulazarus.be", "Teacher@Pass2" },
                { "clara.devos@ulazarus.be", "Teacher@Pass3" },
                { "daan.vermeulen@ulazarus.be", "Teacher@Pass4" },
                { "eva.maes@ulazarus.be", "Teacher@Pass5" },
                { "frank.vdb@ulazarus.be", "Teacher@Pass6" },
                { "greet.declerck@ulazarus.be", "Teacher@Pass7" },
                { "hans.lenaerts@ulazarus.be", "Teacher@Pass8" },
                { "ilse.vandenheuvel@ulazarus.be", "Teacher@Pass9" },
                { "jan.desmet@ulazarus.be", "Teacher@Pass10" }
            };
            foreach (var (email, password) in teacherEmails)
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user != null && string.IsNullOrEmpty(user.PasswordHash))
                {
                    await _userManager.RemovePasswordAsync(user); // just in case
                    await _userManager.AddPasswordAsync(user, password);
                }
            }
        }
        
    }
}
