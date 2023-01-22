using Bean.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bean.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly SolarDbContext _db;

        public CustomerService(SolarDbContext dbContext) {
            _db = dbContext;
        }

        public List<Data.Models.Customer> GetAllCustomers()
        {
            return _db.Customers
                .Include(Customer => Customer.PrimaryAddress)
                .OrderBy(Customer => Customer.LastName)
                .ToList();
        }


        public ServiceResponse<Data.Models.Customer> CreateCustomer(Data.Models.Customer customer)
        {
            try
            {
                _db.Customers .Add(customer);
                _db.SaveChanges();
                return new ServiceResponse<Data.Models.Customer>
                {
                    IsSuccess = true,
                    Message =  "New Customer Added",
                    Time = DateTime.UtcNow,
                    Data= customer
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Customer>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data= customer
                };
            }
        }

        public ServiceResponse<bool> DeleteCustomer(int id)
        {
            var customer = _db.Customers.Find(id);
            var now = DateTime.UtcNow;

            if (customer == null)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Time= now,
                    Message = "Customer to delete not found",
                    Data = false

                };
            }
            try
            {
                _db.Customers.Remove(customer);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSuccess = true,
                    Time = now,
                    Message = "Customer Created",
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSuccess = false,
                    Time = now,
                    Message = e.StackTrace,
                    Data = false
                };
            }

        }

        

        public Data.Models.Customer GetCustomerById(int id)
        {
            return _db.Customers.Find(id); 
        }
    }
}
