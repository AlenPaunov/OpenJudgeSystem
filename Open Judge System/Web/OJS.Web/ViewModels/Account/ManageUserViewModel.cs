﻿namespace OJS.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using Resource = Resources.Account.AccountViewModels;

    public class ManageUserViewModel
    {
        [AllowHtml]
        [Required(ErrorMessageResourceName = "Enter_password_validation",
            ErrorMessageResourceType = typeof(Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "Current_password", ResourceType = typeof(Resource))]
        public string OldPassword { get; set; }

        [AllowHtml]
        [Required(ErrorMessageResourceName = "Enter_new_password_validation",
            ErrorMessageResourceType = typeof(Resource))]
        [StringLength(100, ErrorMessageResourceName = "Password_length_validation_message",
            ErrorMessageResourceType = typeof(Resource), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New_password", ResourceType = typeof(Resource))]
        public string NewPassword { get; set; }

        [AllowHtml]
        [Required(ErrorMessageResourceName = "Enter_new_password_confirmation",
            ErrorMessageResourceType = typeof(Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "New_password_confirmation", ResourceType = typeof(Resource))]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessageResourceName = "New_password_confirm_password_not_matching_validation",
            ErrorMessageResourceType = typeof(Resource))]
        public string ConfirmPassword { get; set; }
    }
}
