using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HR.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.api
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        Repository _repository = Repository.Instance;
        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _repository.GetAllEmployees();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var employee = _repository.GetEmployee(id);
            if (employee != null)
                return new ObjectResult(employee);
            else
                return new NotFoundResult();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Employee employee)
        {
            if (employee.EmployeeId == Guid.Empty)
            {
                return new ObjectResult(_repository.AddEmployee(employee));
            }
            else
            {
                var existingOne = _repository.GetEmployee(employee.EmployeeId);
                existingOne.FirstName = employee.FirstName;
                existingOne.LastName = employee.LastName;
                _repository.UpdateEmployee(existingOne);
                return new ObjectResult(existingOne);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]Employee employee)
        {
            var existingOne = _repository.GetEmployee(employee.EmployeeId);
            existingOne.FirstName = employee.FirstName;
            existingOne.LastName = employee.FirstName;
            _repository.UpdateEmployee(employee);
            return new ObjectResult(existingOne);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _repository.DeleteEmployee(id);
            return new StatusCodeResult(200);
        }
    }
}
