using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test1011_WebAPI.Models;
namespace test1011_WebAPI.Controllers
{
    
    public class MemberController : ApiController
        
    {
        /*會員服務實體物件*/
        CMemberService memberService = new CMemberService();

        public List<Member> GetAllMember() {
            /*呼叫物件方法回傳所有會員資料*/
            var memberList = memberService.MemberList();
            return memberList;
        }
    }
}
