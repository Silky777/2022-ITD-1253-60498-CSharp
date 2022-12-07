using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13Project
{
    public abstract class Customer
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _address1;
        private string _address2;
        private string _city;
        private string _state;
        private string _zipCode;

        public Customer(string firstName, string middleName, string lastName, string address1, string address2, string city, string state, string zipCode)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _address1 = address1;
            _address2 = address2;
            _city = city;
            _state = state;
            _zipCode = zipCode;
        }

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string middleName
        {
            get { return _middleName; }
            set { _middleName = value; }
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
            set { _city = value; }
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
        public virtual string[] returnData()
        {
            if (_address2 != string.Empty)
            {
                return new string[] { $"{_lastName}, {_firstName} {_middleName}", _address1 + Environment.NewLine + _address2 + Environment.NewLine +
                    $"{_city}, {_state} {_zipCode}"};
            } else
            {
                return new string[] {$"{_lastName}, {_firstName} {_middleName}", $"{_address1}" + Environment.NewLine +
                $"{_city}, {_state} {_zipCode}"};
            }
        }
    }

    public class ResidentialCustomer : Customer
    {
        private string _homePhone;
        private string _homeType;
        private string _customerID;
        public ResidentialCustomer(string firstName, string middleName, string lastName, string address1, string address2, string city, string state, string zipCode, string homePhone, string homeType, string customerID) : base(firstName, middleName, lastName, address1, address2, city, state, zipCode)
        {
            _homePhone = homePhone;
            _homeType = homeType;
            _customerID = customerID;
        }

        public string homePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }
        public string homeType
        {
            get { return _homeType; }
            set { _homeType = value; }
        }
        public string customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public override string[] returnData()
        {
            string[] baseData = base.returnData();
            string[] newData = { $"{_homePhone}", $"{_customerID}", $"{_homeType}", "Residential"};
            string[] combinedData = new string[baseData.Length + newData.Length];
            baseData.CopyTo(combinedData, 0);
            newData.CopyTo(combinedData, baseData.Length);
            return combinedData;
        }
    }

    public class CommercialCustomer : Customer
    {
        private string _businessNumber;
        private string _businessName;
        private string _businessID;
        public CommercialCustomer(string firstName, string middleName, string lastName, string address1, string address2, string city, string state, string zipCode, string businessNumber, string businessName, string businessID) : base(firstName, middleName, lastName, address1, address2, city, state, zipCode)
        {
            _businessNumber = businessNumber;
            _businessName = businessName;
            _businessID = businessID;
        }

        public string businessNumber
        {
            get { return _businessNumber; }
            set { _businessNumber = value; }
        }
        public string businessName
        {
            get { return _businessName; }
            set { _businessName = value; }
        }
        public string businessID
        {
            get { return _businessID; }
            set { _businessID = value; }
        }
        public override string[] returnData()
        {
            string[] baseData = base.returnData();
            string[] newData = { $"{_businessNumber}", $"{_businessID}", $"{_businessName}", "Commercial"};
            string[] combinedData = new string[baseData.Length + newData.Length];
            baseData.CopyTo(combinedData, 0);
            newData.CopyTo(combinedData, baseData.Length);
            return combinedData;
        }
    }

    public class GovernmentCustomer : Customer
    {
        private string _governmentNumber;
        private string _governmentSector;
        private string _governmentID;
        public GovernmentCustomer(string firstName, string middleName, string lastName, string address1, string address2, string city, string state, string zipCode, string governmentNumber, string governmentSector, string governmentID) : base(firstName, middleName, lastName, address1, address2, city, state, zipCode)
        {
            _governmentNumber = governmentNumber;
            _governmentSector = governmentSector;
            _governmentID = governmentID;
        }

        public string governmentNumber
        {
            get { return _governmentNumber; }
            set { _governmentNumber = value; }
        }
        public string governmentSector
        {
            get { return _governmentSector; }
            set { _governmentSector = value; }
        }
        public string governmentID
        {
            get { return _governmentID; }
            set { _governmentID = value; }
        }
        public override string[] returnData()
        {
            string[] baseData = base.returnData();
            string[] newData = { $"{_governmentNumber}", $"{_governmentID}", $"{_governmentSector}", "Government"};
            string[] combinedData = new string[baseData.Length + newData.Length];
            baseData.CopyTo(combinedData, 0);
            newData.CopyTo(combinedData, baseData.Length);
            return combinedData;
        }
    }
    public class CustomerList : List<Customer>
    {
        public new void Add(Customer customer) => base.Insert(0, customer);
    }
}
