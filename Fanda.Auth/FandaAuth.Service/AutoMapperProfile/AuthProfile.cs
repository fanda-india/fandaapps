using AutoMapper;
using FandaAuth.Domain;
using FandaAuth.Service.Dto;
using FandaAuth.Service.ViewModels;

namespace Fanda.Service.AutoMapperProfile
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            #region Tenant models

            CreateMap<Tenant, TenantDto>()
                .ReverseMap();
            CreateMap<User, RegisterViewModel>()
                .ForMember(vm => vm.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(vm => vm.Password, opt => opt.Ignore())
                .ForMember(vm => vm.ConfirmPassword, opt => opt.Ignore())
                .ForMember(vm => vm.AgreeTerms, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<User, UserDto>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(vm => vm.Token, opt => opt.Ignore())
                //.ForPath(vm => vm.Organizations, opt => opt.MapFrom(src => src.OrgUsers.Select(c => c.Organization).ToList()))
                .ForMember(vm => vm.Password, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.MapFrom(vm => vm.Id));
            CreateMap<RefreshToken, RefreshTokenDto>()
                .ReverseMap();
            CreateMap<RefreshToken, ActiveTokenDto>();
            CreateMap<Role, RoleDto>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.MapFrom(vm => vm.Id));

            #endregion Tenant models

            #region Application models

            CreateMap<Application, ApplicationDto>()
                //.ForPath(vm => vm.Resources, opt => opt.MapFrom(src => src.AppResources.Select(c => c.Resource).ToList()))
                .ReverseMap();
            // .ForMember(x => x.AppResources,
            //     src => src.MapFrom((appVM, app, oc, context) =>
            //       {
            //           return appVM.Resources?.Select(r => new AppResource
            //           {
            //               ApplicationId = appVM.Id,
            //               Application = app,
            //               ResourceId = r.Id,
            //               Resource = context.Mapper.Map<ResourceDto, Resource>(r)
            //           }).ToList();
            //       }));

            // CreateMap<Resource, ResourceDto>()
            //     .ReverseMap();
            // CreateMap<Action, ActionDto>()
            //     .ReverseMap();

            #endregion Application models

            #region Maps - Many to many

            CreateMap<AppResource, AppResourceDto>()
                .ReverseMap();
            // CreateMap<ResourceAction, ResourceActionDto>()
            //     .ReverseMap();
            CreateMap<RolePrivilege, RolePrivilegeDto>()
                //.ForMember(vm => vm.ApplicationId, opt => opt.MapFrom(src => src.AppResource.ApplicationId))
                //.ForMember(vm => vm.ResourceId, opt => opt.MapFrom(src => src.AppResource.ResourceId))
                //.ForMember(vm => vm.ResourceId, opt => opt.MapFrom(src => src.ResourceAction.ResourceId))
                //.ForMember(vm => vm.ActionId, opt => opt.MapFrom(src => src.ResourceAction.ActionId))
                .ReverseMap();

            #endregion Maps - Many to many

            #region ViewModel to Dto

            CreateMap<UserDto, RegisterViewModel>()
                .ForMember(vm => vm.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(vm => vm.ConfirmPassword, opt => opt.Ignore())
                .ForMember(vm => vm.AgreeTerms, opt => opt.Ignore())
                .ReverseMap();

            #endregion ViewModel to Dto

            #region List Dto

            CreateMap<Tenant, TenantListDto>();
            CreateMap<User, UserListDto>();

            CreateMap<Application, ApplicationListDto>();
            //CreateMap<Resource, ResourceListDto>();
            //CreateMap<Action, ActionListDto>();

            #endregion List Dto
        }
    }
}
