using System;
using MagicVilla_API.Dto;
using MagicVilla_API.Models;

namespace MagicVilla_API.Repository.IRepository
{
	public interface IUserRepository
	{
		bool IsUniqueUser(string username);

		Task<LoginResponseDTO> Login(LoginRequestDTO loginRequesrDTO);

        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}

