using System;
using System.IO;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Settings.Configuration;
using ProgressOfStudents.Data;
using ProgressOfStudents.Repositories;
using ProgressOfStudents.Repositories.Implementations;
using ProgressOfStudents.Forms;

namespace ProgressOfStudents
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            ApplicationConfiguration.Initialize();

            try
            {
                Application.Run(CreateContainer().Resolve<FormDeanery>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build())
                .CreateLogger());

            container.AddExtension(new LoggingExtension(loggerFactory));

            container.RegisterType<DataContext>(new PerResolveLifetimeManager());

            container.RegisterType<IDeanOfficeRepository, DeanOfficeRepository>(new TransientLifetimeManager());
            container.RegisterType<IDepartmentRepository, DepartmentRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());
            container.RegisterType<ITeacherRepository, TeacherRepository>(new TransientLifetimeManager());
            container.RegisterType<IStreamRepository, StreamRepository>(new TransientLifetimeManager());
            container.RegisterType<IGroupRepository, GroupRepository>(new TransientLifetimeManager());
            container.RegisterType<IStudentRepository, StudentRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineAssignmentRepository, DisciplineAssignmentRepository>(new TransientLifetimeManager());
            container.RegisterType<IAcademicPerformanceRepository, AcademicPerformanceRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}