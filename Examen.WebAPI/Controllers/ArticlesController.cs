using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

using Examen.Data.Context;
using Examen.Data.DTO;
using Examen.Data.Results;
using Examen.Data.Models;

namespace Examen.WebAPI.Controllers
{
    [ApiController]
    [Route("Services/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly ApplicationDBContext db;

        public ArticlesController(ApplicationDBContext _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetArticles()
        {
            try
            {
                if (db.Articles.Count() <= 0)
                {
                    return NotFound(CreateNotFound());
                }

                var articles = from x in db.Articles
                               select new ArticleDTO()
                               {
                                   Id = x.Id,
                                   Name = x.Name,
                                   Description = x.Description,
                                   Price = x.Price,
                                   Total_In_Shelf = x.Total_In_Shelf,
                                   Total_In_Vault = x.Total_In_Vault,
                                   Store_Id = x.Store.Id,
                                   Store_Name = x.Store.Name
                               };
                
                ArticlesResult Res = new ArticlesResult()
                {
                    Articles = await articles.ToListAsync(),
                    Success = true,
                    Total_Elements = await db.Articles.CountAsync(),
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
        public async Task<ActionResult> GetArticle(int Id)
        {
            try
            {
                if (db.Articles.Count() <= 0)
                {
                    return NotFound(CreateNotFound());
                }

                var article = from x in db.Articles
                              where x.Id == Id
                              select new ArticleDTO()
                              {
                                Id = x.Id,
                                Name = x.Name,
                                Description = x.Description,
                                Price = x.Price,
                                Total_In_Shelf = x.Total_In_Shelf,
                                Total_In_Vault = x.Total_In_Vault,
                                Store_Id = x.Store.Id,
                                Store_Name = x.Store.Name
                              };

                ArticleResult Res = new ArticleResult()
                {
                    Article = await article.FirstOrDefaultAsync(),
                    Success = true,
                    Total_Elements = 1,
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
        [Route("Stores/{Id}")]
        public async Task<ActionResult> GetStores(string Id)
        {
            try
            {
                int nId = 0;
                try
                {
                    nId = int.Parse(Id);
                }
                catch (Exception)
                {
                    return BadRequest(CreateBadRequest());
                }
                
                if(db.Articles.Where(w => w.Store.Id == nId).Count()<=0)
                {
                    return NotFound(CreateNotFound());
                }

                var articles = from x in db.Articles
                               where x.Store.Id == nId
                               select new ArticleDTO()
                               {
                                   Id = x.Id,
                                   Name = x.Name,
                                   Description = x.Description,
                                   Price = x.Price,
                                   Total_In_Shelf = x.Total_In_Shelf,
                                   Total_In_Vault = x.Total_In_Vault,
                                   Store_Id = x.Store.Id,
                                   Store_Name = x.Store.Name
                               };

                ArticlesResult Res = new ArticlesResult()
                {
                    Articles = await articles.ToListAsync(),
                    Success = true,
                    Total_Elements = await db.Articles.Where(w => w.Store.Id == nId).CountAsync(),
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
        public async Task<ActionResult> Post(Article NewArticle)
        {
            try
            {
                NewArticle.Store = db.Stores.FirstOrDefault(f => f.Id == NewArticle.Store.Id);
                db.Articles.Add(NewArticle);
                await db.SaveChangesAsync();

                var Res = new ArticleResult()
                {
                    Article = new ArticleDTO()
                    {
                        Id = NewArticle.Id,
                        Name = NewArticle.Name,
                        Description = NewArticle.Description,
                        Price = NewArticle.Price,
                        Total_In_Shelf = NewArticle.Total_In_Shelf,
                        Total_In_Vault = NewArticle.Total_In_Vault,
                        Store_Id = NewArticle.Store.Id,
                        Store_Name = NewArticle.Store.Name
                    },
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
        public async Task<ActionResult> Put(Article EditedArticle)
        {
            try
            {
                EditedArticle.Store = db.Stores.FirstOrDefault(f => f.Id == EditedArticle.Store.Id);
                db.Articles.Update(EditedArticle);
                await db.SaveChangesAsync();

                var Res = new ArticleResult()
                {
                    Article = new ArticleDTO()
                    {
                        Id = EditedArticle.Id,
                        Name = EditedArticle.Name,
                        Description = EditedArticle.Description,
                        Price = EditedArticle.Price,
                        Total_In_Shelf = EditedArticle.Total_In_Shelf,
                        Total_In_Vault = EditedArticle.Total_In_Vault,
                        Store_Id = EditedArticle.Store.Id,
                        Store_Name = EditedArticle.Store.Name
                    },
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
                db.Articles.Where(w => w.Id == Id).ExecuteDelete();
                await db.SaveChangesAsync();

                var Res = new ArticleResult()
                {
                    Article = null,
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

        private ErrorResult CreateBadRequest()
        {
            return new ErrorResult()
            {
                Success = false,
                Error_Code = EnumResult.BAD_REQUEST,
                Error_Msg = "Bad Request",
            };
        }

    }
}
