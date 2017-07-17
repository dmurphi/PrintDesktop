// <copyright file="IUserLoginModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace PrintDesktopApp.Models
{
    /// <summary>
    /// exposed public interface for the login existing user model class
    /// </summary>
    public interface IUserLoginModel
    {
        /// <summary>
        /// Gets or sets the user password
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Gets or sets the user phone number
        /// </summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user email address
        /// </summary>
        string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the user sent code
        /// </summary>
        string SmsCode { get; set; }
    }
}