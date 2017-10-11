using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test1011_WebAPI.Models {
    public class CMemberService {
        /*資料庫實體物件*/
        DB1006Entities db = new DB1006Entities();
        public List<Member> MemberList() {
            /*回傳所有會員資料 型別為Member*/
            var query = from o in db.Members
                        select o;
            return query.ToList();
        }
    }
}