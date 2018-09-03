﻿namespace MusicX.Web.Client.Infrastructure
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MusicX.Common.Models;
    using MusicX.Web.Shared;
    using MusicX.Web.Shared.Account;
    using MusicX.Web.Shared.Application;
    using MusicX.Web.Shared.Songs;

    public interface IApiClient
    {
        Task<ApiResponse<IEnumerable<SongListItem>>> GetSongsList();

        Task<ApiResponse<ApplicationStartResponseModel>> ApplicationStart();

        Task<ApiResponse<ApplicationStopResponseModel>> ApplicationStop(ApplicationStopRequestModel request);

        Task<ApiResponse<UserRegisterResponseModel>> UserRegister(UserRegisterRequestModel request);

        Task<ApiResponse<UserLoginResponseModel>> UserLogin(UserLoginRequestModel request);
    }
}