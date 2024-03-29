﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CookBook.Areas.Admin.Constants.AdminConstants;


namespace CookBook.Areas.Admin.Controllers
    {

    [Area(AreaName)]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRolleName)]

    public class BaseAdminController : Controller
        {

        }
    }
