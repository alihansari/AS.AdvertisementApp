﻿using AS.AdvertisementApp.Business.Interfaces;
using AS.AdvertisementApp.Dtos;
using AS.AdvertisementApp.UI.Extensions;
using AS.AdvertisementApp.UI.Models;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IAppUserService _appUserService;
        private readonly IValidator<UserCreateModel> _userCreateModelValidator;
        private readonly IMapper _mapper;


        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateModelValidator, IAppUserService appUserService, IMapper mapper)
        {
            _genderService = genderService;
            _userCreateModelValidator = userCreateModelValidator;
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public async Task<IActionResult> SignUp()
        {
            var response = await _genderService.GetAllAsync();
            var model = new UserCreateModel
            {
                Genders = new SelectList(response.Data, "Id", "Definition")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel model)
        {
            var result = _userCreateModelValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<AppUserCreateDto>(model);
                var createResponse=await _appUserService.CreateAsync(dto);
                return this.ResponseRedirectAction(createResponse, "SignIn");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            var response = await _genderService.GetAllAsync();
            model.Genders = new SelectList(response.Data, "Id", "Definition",model.GenderId);
            return View(model);
        }
    }
}
