using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using ProgressOfStudents.Forms; 
using ProgressOfStudents.Repositories;
using ProgressOfStudents.Repositories.Implementations;

namespace ProgressOfStudents.Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(CreateContainer().Resolve<FormDeanery>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

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