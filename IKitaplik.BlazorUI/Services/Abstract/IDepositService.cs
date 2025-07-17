﻿using IKitaplik.BlazorUI.Responses;
using IKitaplik.Entities.DTOs.DepositDTOs;

namespace IKitaplik.BlazorUI.Services.Abstract
{
    public interface IDepositService
    {
        Task<Response> DepositGivenAsync(DepositAddDto depositAddDto);
        Task<Response> DepositReceivedAsync(DepositUpdateDto depositUpdateDto);
        Task<Response> DeleteAsync(int id);
        Task<Response> ExtendDueDateAsync(DepositExtentDueDateDto depositExtentDueDateDto);
        Task<Response<List<DepositGetDTO>>> GetAllAsync();
        Task<Response<DepositGetDTO>> GetByIdAsync(int id);
    }
}
