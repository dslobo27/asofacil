﻿using AsoFacil.Application.Contracts;
using AsoFacil.Application.Impl.Services;
using AsoFacil.Domain.Contracts.Repositories;
using AsoFacil.Domain.Contracts.Services;
using AsoFacil.Domain.Services;
using AsoFacil.InfraStructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AsoFacil.IoC
{
    public class DependencyResolver
    {
        public static void Register(IServiceCollection services)
        {
            #region ApplicationServices

            services.AddTransient<IEmpresaApplicationService, EmpresaApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<ISolicitacaoAtivacaoEmpresaApplicationService, SolicitacaoAtivacaoEmpresaApplicationService>();
            services.AddTransient<ITipoUsuarioApplicationService, TipoUsuarioApplicationService>();
            services.AddTransient<ICargoApplicationService, CargoApplicationService>();

            #endregion ApplicationServices

            #region DomainServices

            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient<IEmpresaDomainService, EmpresaDomainService>();
            services.AddTransient<IStatusSolicitacaoAtivacaoEmpresaDomainService, StatusSolicitacaoAtivacaoEmpresaDomainService>();
            services.AddTransient<ISolicitacaoAtivacaoEmpresaDomainService, SolicitacaoAtivacaoEmpresaDomainService>();
            services.AddTransient<ITipoUsuarioDomainService, TipoUsuarioDomainService>();
            services.AddTransient<ICargoDomainService, CargoDomainService>();

            #endregion DomainServices

            #region Repositories

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<ISolicitacaoAtivacaoEmpresaRepository, SolicitacaoAtivacaoEmpresaRepository>();
            services.AddTransient<IStatusSolicitacaoAtivacaoEmpresaRepository, StatusSolicitacaoAtivacaoEmpresaRepository>();
            services.AddTransient<ITipoUsuarioRepository, TipoUsuarioRepository>();
            services.AddTransient<ICargoRepository, CargoRepository>();

            #endregion Repositories
        }
    }
}