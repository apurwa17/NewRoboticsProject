using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsToolData.Model;

namespace RoboticsToolData.Repository
{
    public class LoginRepository
    {
        public tblUserDetail GetUserForAuthentication(string emailId)
        {
            using (RoboticDataEntities entity = new RoboticDataEntities())
            {
                tblUserDetail objtblUserDetail = new tblUserDetail();
                objtblUserDetail = entity.tblUserDetails.Where(q => q.Email.Trim().ToLower() == emailId.Trim().ToLower()).FirstOrDefault();
                return objtblUserDetail;
            }
        }
    }
}
