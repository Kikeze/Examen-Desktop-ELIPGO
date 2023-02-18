using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Examen.Data.Context;
using Examen.Data.Models;
using Examen.Data.Results;

namespace Examen.WebAPI.Controllers
{
    [ApiController]
    [Route("Services/[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly ApplicationDBContext db;

        public StoresController(ApplicationDBContext _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetStores()
        {
            try
            {
                if (db.Stores.Count() <= 0)
                {
                    return NotFound(CreateNotFound());
                }

                StoresResult Res = new StoresResult()
                {
                    Stores = await db.Stores.ToListAsync(),
                    Success = true,
                    Total_Elements = await db.Stores.CountAsync()
                };

                return Ok(Res);
            }
            catch (Exception ex)
            {
                ErrorResult ErrRes = new ErrorResult()
                {
                    Success = false,
                    Error_Code = EnumResult.SERVER_ERROR,
                    Error_Msg = ex.Message
                };
                
                return StatusCode(500, ErrRes);
            }
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult> GetStore(int Id)
        {
            try
            {
                if (db.Stores.Count() <= 0)
                {
                    return NotFound(CreateNotFound());
                }

                StoreResult Res = new StoreResult()
                {
                    Store = await db.Stores.FirstOrDefaultAsync(f => f.Id == Id),
                    Success = true,
                    Total_Elements = 1
                };

                return Ok(Res);
            }
            catch (Exception ex)
            {
                ErrorResult ErrRes = new ErrorResult()
                {
                    Success = false,
                    Error_Code = EnumResult.SERVER_ERROR,
                    Error_Msg = ex.Message
                };

                return StatusCode(500, ErrRes);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(Store NewStore)
        {
            try
            {
                db.Stores.Add(NewStore);
                await db.SaveChangesAsync();

                var Res = new StoreResult()
                {
                    Store = NewStore,
                    Success = true,
                    Total_Elements = 1
                };

                return Ok(Res);
            }
            catch (Exception ex)
            {
                ErrorResult ErrRes = new ErrorResult()
                {
                    Success = false,
                    Error_Code = EnumResult.SERVER_ERROR,
                    Error_Msg = ex.Message
                };

                return StatusCode(500, ErrRes);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(Store EditedStore)
        {
            try
            {
                db.Stores.Update(EditedStore);
                await db.SaveChangesAsync();

                var Res = new StoreResult()
                {
                    Store = EditedStore,
                    Success = true,
                    Total_Elements = 1
                };

                return Ok(Res);
            }
            catch (Exception ex)
            {
                ErrorResult ErrRes = new ErrorResult()
                {
                    Success = false,
                    Error_Code = EnumResult.SERVER_ERROR,
                    Error_Msg = ex.Message
                };

                return StatusCode(500, ErrRes);
            }
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                db.Articles.Where(w => w.Store.Id == Id).ExecuteDelete();
                db.Stores.Where(w => w.Id == Id).ExecuteDelete();
                await db.SaveChangesAsync();

                var Res = new StoreResult()
                {
                    Store = null,
                    Success = true,
                    Total_Elements = 1
                };

                return Ok(Res);
            }
            catch (Exception ex)
            {
                ErrorResult ErrRes = new ErrorResult()
                {
                    Success = false,
                    Error_Code = EnumResult.SERVER_ERROR,
                    Error_Msg = ex.Message
                };

                return StatusCode(500, ErrRes);
            }
        }

        private ErrorResult CreateNotFound()
        {
            return new ErrorResult()
            {
                Success = false,
                Error_Code = EnumResult.NOT_FOUND,
                Error_Msg = "Record Not Found",
            };
        }


    }

}
