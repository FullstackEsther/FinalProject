using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.RepositoryInterfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        bool Exist(Expression<Func<Course, bool>> predicate);
        Task<Course> GetCourse(Expression<Func<Course, bool>> predicate);
        Task<IEnumerable<Course>> GetAllCourse();
        Task<IEnumerable<Course>> GetAllCourses(Expression<Func<Course, bool>> predicate);
        void Delete(Course course);
        Task<IReadOnlyList<Module>> AddModules(IReadOnlyList<Module> modules);
    }
}