// <copyright file="UserLoginModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace PrintDesktopApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// model class for login existing user
    /// </summary>
    public class UserLoginModel : IUserLoginModel
    {
        /// <summary>
        /// Gets or sets the user email address
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the user password field
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user sent code
        /// </summary>
        public string SmsCode { get; set; }
    }
}
