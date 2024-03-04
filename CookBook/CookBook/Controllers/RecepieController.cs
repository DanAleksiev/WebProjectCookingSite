﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using CookBook.Core.Models.Utilities;
using CookBook.Infrastructures.Data;
using CookBook.Core.Models.Recepies;
using CookBook.Infrastructures.Data.Models.Shared;
using CookBook.Core.Models.Ingredients;
using CookBook.Core;
using CookBook.Core.DTO;
using CookBook.Infrastructures.Data.Models.Food;
using CookBook.Core.Utilities;

namespace CookBook.Controllers
    {
    [Authorize]
    public class RecepieController : Controller
        {
        private static List<Ingredient> addIngredients = new List<Ingredient>();
        private static List<FoodStep> addSteps { get; set; } = new List<FoodStep>();

        private readonly CookBookDbContext context;
        public RecepieController(CookBookDbContext _context)
            {
            context = _context;
            }

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
        private async Task<IEnumerable<UtilTypeModel>> GetMeasurmentType()
            {
            return await context
                .Measurements
                .Select(t => new UtilTypeModel()
                    {
                    Id = t.Id,
                    Name = t.Name,
                    })
                .ToListAsync();
            }

        private async Task<IEnumerable<UtilTypeModel>> GetTemperatureType()
            {
            return await context
                .TemperaturesMeasurments
                .Select(t => new UtilTypeModel()
                    {
                    Id = t.Id,
                    Name = t.Name,
                    })
                .ToListAsync();
            }
        private async Task<IEnumerable<UtilTypeModel>> GetOvenType()
            {
            return await context
                .OvenTypes
                .Select(t => new UtilTypeModel()
                    {
                    Id = t.Id,
                    Name = t.Name,
                    })
                .ToListAsync();
            }
        private async Task<IEnumerable<UtilTypeModel>> GetRecepieType()
            {
            return await context
                .RecepieTypes
                .Select(t => new UtilTypeModel()
                    {
                    Id = t.Id,
                    Name = t.Name,
                    })
                .ToListAsync();
            }



        [HttpGet]
        public IActionResult All()
            {
            var allRecepies = context
                .FoodRecepies
                .Select(x => new AllRecepieViewModel()
                {
                Name = x.Name,
                DatePosted = x.DatePosted.ToString("dd/MM/yyyy"),
                Image = x.Image,
                TumbsUp = x.TumbsUp,
                Description = x.Descripton,
                Owner = x.Owner.UserName
                })
                .ToList();

            return View(allRecepies);
            }

        [HttpPost]
        public IActionResult All(TempView model)
            {
            var name = model.Name;

            return View();
            }

        [HttpGet]
        public async Task<IActionResult> Add()
            {
            var model = new RecepieViewModel()
                {
                RecepieTypes = await GetRecepieType(),
                OvenTypes = await GetOvenType(),
                MeasurmentTypes = await GetMeasurmentType(),
                TemperatureTypes = await GetTemperatureType(),
                };

            return View(model);
            }

        [HttpPost]
        public async Task<IActionResult> Add(RecepieViewModel model)
            {
            if (!ModelState.IsValid)
                {
                return View("Add", model);
                }



            var NewRecepie = new FoodRecepie()
                {
                Name = model.Name,
                Steps = addSteps,
                Descripton = model.Description,
                DatePosted = DateTime.Now,
                Image = model.Image,
                PrepTime = model.PrepTime,
                CookTime = model.CookTime,
                Portions = model.Portions,
                OvenTypeId = model.OvenTypeId,
                RecepieTypeId = model.RecepieTypeId,
                Origen = model.Origen,
                Temperature = model.Temperature,
                TemperatureMeasurmentId = model.TemperatureTypeId,
                OwnerId = GetUserId(),
                TumbsUp = 0,
                IsPrivate = model.IsPrivate,
                };


            foreach (var ing in addIngredients)
                {
                await context.Ingredients.AddAsync(ing);
                await context.AddAsync(new IngredientFoodRecepie
                    {
                    Ingredient = ing,
                    Recepie = NewRecepie
                    });
                }

            foreach (var step in addSteps)
                {
                step.FoodRecepie = NewRecepie;
                await context.FoodStep.AddAsync(step);

                }



            await context.FoodRecepies.AddAsync(NewRecepie);


            try
                {
                await context.SaveChangesAsync();
                }
            catch (Exception ex)
                {
                await Console.Out.WriteLineAsync(ex.Message);
                if (ex.InnerException != null)
                    {
                    await Console.Out.WriteLineAsync(ex.GetCompleteMessage());
                }
            }

            addIngredients.Clear();
            addSteps.Clear();
            return RedirectToAction("All");
            }

        [HttpGet]
        public async Task<IActionResult> _AddIngredientPartial()
            {
            var model = new IngredientInputViewModel()
                {
                Measurements = await GetMeasurmentType(),
                };

            return View(model);
            }


        public IActionResult Delete()
            {
            return View();
            }

        public IActionResult EditYourRecepie()
            {
            return View();
            }

        public IActionResult EditSomeoneOtherRecepie()
            {
            return View();
            }



        //if you submit a full form ajax doesnt sends you the bellow data,
        //but if you try to submit only them it does?
        // work around create a separate button to submit the ing and steps
        [HttpPost]
        public JsonResult POSTIngredients(string allIngredient, string allSteps)
            {
            TempIngrediantModel[] ingredientsListDTO = allIngredient.DeserializeFromJson<TempIngrediantModel[]>();
            TempStepModel[] stepListDTO = allSteps.DeserializeFromJson<TempStepModel[]>();

            foreach (var ing in ingredientsListDTO)
                {
                if (ing.Name != null)
                    {
                    Ingredient newIng = new Ingredient()
                        {
                        Name = ing.Name,
                        Amount = ing.Amount,
                        MeasurementId = ing.MeasurementId
                        };

                    addIngredients.Add(newIng);
                    }
                }
            int stepPosition = 1;
            foreach (var step in stepListDTO)
                {
                if (step.Description != null)
                    {
                    FoodStep newStep = new FoodStep()
                        {
                        Position = stepPosition,
                        Description = step.Description,
                        };

                    addSteps.Add(newStep);
                    }
                }
            //TODO: figure a way to add to the current recepie without creating a global var?!? or not
            return new JsonResult(Ok());
            }

        }
    }
