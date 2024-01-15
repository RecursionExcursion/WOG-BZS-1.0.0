using WOG_1._0._0.Repository;

namespace WOG_1._0._0.Service
{
    public class WorkoutService
    {

        private WorkoutRepository repository;

        public WorkoutService(WorkoutRepository repository)
        {
            this.repository = repository;
        }

        internal string GetString()
        {
            return "Hello from service";
        }
    }
}
