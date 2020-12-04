using adet_mid_assignment_jintalan_mikaela.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adet_mid_assignment_jintalan_mikaela.Models
{
    public static class TaskRepository
    {
        private static List<Tasks> responses = new List<Tasks>();
        public static IEnumerable<Tasks> Response => responses;
        public static void addResponse(Tasks response)
        {
            responses.Add(response);
        }
    }
}
