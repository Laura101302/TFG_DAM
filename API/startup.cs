using System.Reflection;
using AutoMapper;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddTransient<PopZoneContext>(_ =>
            new PopZoneContext(Configuration.GetConnectionString("DefaultConnection")));

        services.AddSwaggerGen(options =>
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        });

        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new OpinionProfile());
            mc.AddProfile(new PMayoristaProfile());
            mc.AddProfile(new PParticularProfile());
            mc.AddProfile(new UsuarioProfile());
            mc.AddProfile(new VParticularProfile());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        services.AddTransient<IOpinionService, OpinionService>();
        services.AddTransient<IPMayoristaService, PMayoristaService>();
        services.AddTransient<IPParticularService, PParticularService>();
        services.AddTransient<IUsuarioService, UsuarioService>();
        services.AddTransient<IVParticularService, VParticularService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();

        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }


}
