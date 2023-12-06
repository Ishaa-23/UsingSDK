using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

public class Example
{
    public static void Main()
    {

        Configuration config = new Configuration();
        config.BasePath = "http://localhost:5283";
        var apiInstance = new EmployeeApi(config);
        config.BasePath = "http://localhost:5093";
        var studentApi = new StudentApi(config);
        List<Student> results = studentApi.ApiStudentGet();
        Console.WriteLine("The results for students are -");
        for(var i=0;i<results.Count;i++)
        {
            Console.WriteLine(results[i]);
        }
        Console.WriteLine("Enter id-");
        int id = Convert.ToInt32(Console.ReadLine());
        List<Employee> res = apiInstance.ApiEmployeeIdDelete(id);
        for (var i = 0; i < res.Count; i++)
        {
            Console.WriteLine(res[i]);
        }

    }
}