using System;
using Xunit;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using StudentExercisesApi.Model;
using System.Net;

namespace TestingStudentExercises
{
    public class ExercisesTesting
    {
        [Fact]
        public async Task Test_getAll_Exercise()
        {
            using (var client = new APIClientProvider().Client)
            {
                var response = await client.GetAsync("/exercise");
                response.EnsureSuccessStatusCode();
                string responceBody = await response.Content.ReadAsStringAsync();
                var studentList = JsonConvert.DeserializeObject<List<Student>>(responceBody);
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.True(studentList.Count > 1);
            }
        }
    }
}
