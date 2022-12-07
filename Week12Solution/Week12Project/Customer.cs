using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Project
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _address1;
        private string _address2;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _phoneNumber;

        public Customer(string firstName, string lastName, string address1, string address2, string city, string state, string zipCode, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address1 = address1;
            _address2 = address2;
            _city = city;
            _state = state;
            _zipCode = zipCode;
            _phoneNumber = phoneNumber;
        }

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string city
        {
            get { return _city; }
            set{ _city = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string zipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public static Customer operator + (Customer left, Customer right)
        {
            return new Customer($"{left.firstName}-{right.firstName}", $"{left.lastName}-{right.lastName}",
                $"{left.address1}-{right.address1}", $"{left.address2}-{right.address2}",
                $"{left.city}-{right.city}", $"{left.state}-{right.state}",
                $"{left.zipCode}-{right.zipCode}", $"{left.phoneNumber}-{right.phoneNumber}");
        }
    }
    public class CustomerList
    {
        private List<Customer> customers;
        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count => customers.Count;
        public Customer this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                } else if (i >= customers.Count())
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(string firstName, string lastName, string address1, string address2, string city, string state, string zipCode, string phoneNumber)
        {
            Customer c = new Customer(firstName, lastName, address1, address2, city, state, zipCode, phoneNumber);
            customers.Add(c);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
