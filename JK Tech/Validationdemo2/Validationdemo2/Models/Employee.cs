using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Validationdemo2.Common;

namespace Validationdemo2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        //public string FirstName
        //{
        //    get;
        //    set;
        //}
        //[Required(ErrorMessage = "Last Name is Required")]
        //[StringLength(30, MinimumLength = 4,
        //          ErrorMessage = "Last name should be between 4 and 30 characters")]
        //public string LastName
        //{
        //    get;
        //    set;
        //}
        //[Required(ErrorMessage = "Email id is required")]
        ////[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ////                    ErrorMessage = "Please enter a valid email address")]
        //public string EmailId
        //{
        //    get;
        //    set;
        //}
        //[RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        //public string UserName
        //{
        //    get;
        //    set;
        //}
        //[Range(25, 60, ErrorMessage = "Age must be between 25 and 60")]
        //public int Age
        //{
        //    get;
        //    set;
        //}
        //[Range(typeof(DateTime), "01-01-1970", "01-01-2005",
        //              ErrorMessage = "Date of Birth Must be between 01-01-1970 and 01-01-2005")]
        //[DateRange("1/1/2000",ErrorMessage =" DOb between 1/1/2000 to current date")]
      //Range(typeof(DateTime),"1/1/2000","1/1/2010",ErrorMessage =" date betwee {1} and {2}")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
       //Range(typeof(DateTime), "1/1/2000", "1/1/2010", ErrorMessage = " date betwee {1} and {2}")]
        [DataType(DataType.DateTime)]
        [DateRange("01/01/2000",ErrorMessage =" Value between {1} and today date")]

        public DateTime DOB { get; set; }

        //[MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
        //[MaxLength(25, ErrorMessage = "The Address cannot be more than 25 characters")]
        //public string Address
        //{
        //    get;
        //    set;
        //}
        //[DataType(DataType.PostalCode, ErrorMessage = "Please Enter a valid PIN/ZIP Code")]
        //public string PostalCode
        //{
        //    get;
        //    set;
        //}
        //[DataType(DataType.Url, ErrorMessage = "Please Enter a valid URL")]
        //public string URL
        //{
        //    get;
        //    set;
        //}
      
        //[DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter a valid Phone Number")]
        //public string Mobile
        //{
        //    get;
        //    set;
        //}
        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password is Required")]
        //public string Password
        //{
        //    get;
        //    set;
        //}
        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Confirm Password is Required")]
        //public string ConfirmPassword
        //{
        //    get;
        //    set;
        //}
    }
}