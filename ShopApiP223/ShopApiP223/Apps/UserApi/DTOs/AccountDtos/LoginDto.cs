﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApiP223.Apps.UserApi.DTOs.AccountDtos
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }


    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(4).MaximumLength(20);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).MaximumLength(25);
        }
    }
}
