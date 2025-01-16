using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UserManagement.BackEnd.Core.Context;
using UserManagement.BackEnd.Core.DTO.Auth;
using UserManagement.BackEnd.Core.DTO.Log;
using UserManagement.BackEnd.Core.Entities;
using UserManagement.BackEnd.Core.Interfaces;

namespace UserManagement.BackEnd.Core.Services
{
    public class LogService : ILogService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper mapper;

        public LogService(ApplicationDBContext _dbContext,IMapper mapper) 
        {
            this._dbContext = _dbContext;
            this.mapper = mapper;   
        }

        public async Task SaveNewLog(string UserName, string Description)
        {
            try
            {
                var logInfo = new Log()
                {
                    UserName = UserName,
                    Description = Description
                };

                await _dbContext.Logs.AddAsync(logInfo);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public async Task<IEnumerable<GetLogDTO>> GetLogsAsync()
        {
            IEnumerable<GetLogDTO> getDTO = null;
            try
            {
                var logInfo = await _dbContext.Logs.ToListAsync();

                getDTO = mapper.Map<IEnumerable<GetLogDTO>>(logInfo); 

                //getDTO = await _dbContext.Logs
                //                    .Select(q => new GetLogDTO() 
                //                    {
                //                        UserName = q.UserName,
                //                        Description = q.Description,
                //                        CreatedAt = q.CreatedAt
                //                    })
                //                    .OrderByDescending(q => q.CreatedAt)
                //                    .ToListAsync();
            }
            catch (Exception ex) 
            { Console.WriteLine(ex); }

            return getDTO;
        }

        public async Task<IEnumerable<GetLogDTO>> GetMyLogAsync(ClaimsPrincipal User)
        {
            IEnumerable<GetLogDTO> getDTO = null;
            try
            {
                var logUserInfo = await _dbContext.Logs.
                                            Where(q => q.UserName == User.Identity.Name)
                                            .ToListAsync();

                getDTO = mapper.Map<IEnumerable<GetLogDTO>>(logUserInfo);
                //getDTO = await _dbContext.Logs
                //                    .Where(q => q.UserName == User.Identity.Name)
                //                    .Select(q => new GetLogDTO()
                //                    {
                //                        UserName = q.UserName,
                //                        Description = q.Description,
                //                        CreatedAt = q.CreatedAt
                //                    })
                //                    .OrderByDescending(q => q.CreatedAt)
                //                    .ToListAsync();
            }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            return getDTO;
        }

    }
}
