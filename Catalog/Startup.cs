using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Catalog.Database;
using Catalog.Features.QuestionFeatures.AddQuestion;
using Catalog.Repositories.ComplianceProcesses;
using Catalog.Repositories.ComplianceRisks;
using Catalog.Repositories.Questionnaires;
using Catalog.Repositories.Questions;
using Catalog.Repositories.RelationStages;
using Catalog.Repositories.Requests;
using Catalog.Repositories.Requirements;
using Catalog.Repositories.Triggers;
using Catalog.Repositories.Users;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace Catalog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMediatR(typeof(AddQuestionRequest).GetTypeInfo().Assembly);
            services.AddScoped<IQuestionsRepository, QuestionsRepository>();
            services.AddScoped<IRequirementsRepository, RequirementsRepository>();
            services.AddScoped<IRequestsRepository, RequestsRepository>();
            services.AddScoped<IRelationStagesRepository, RelationStagesRepository>();
            services.AddScoped<IComplianceRisksRepository, ComplianceRisksRepository>();
            services.AddScoped<IComplianceProcessesRepository, ComplianceProcessesRepository>();
            services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ITriggersRepository, TriggersRepository>();
            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithOrigins(Configuration.GetSection("CorsOrigins").Get<string[]>())
                    .AllowCredentials());
            });
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "Catalog", Version = "v1"}); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Catalog v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}