using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// 管理员id
        /// </summary>
        public int Aid { get; set; }
        /// <summary>
        /// 管理员用户名
        /// </summary>
        public string Aname { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string Apasswork { get; set; }
    }
}
