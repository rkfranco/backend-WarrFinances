using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class OperationRepository : BaseRepository<Operation>
    {

        public override List<Operation> GetAll()
        {
            List<Operation> operations = new List<Operation>();
            using (WarrContext warrContext = new WarrContext())
            {
                operations = warrContext.Operation.Include("User").Include("Category").ToList();
            }
            return operations;
        }

        public List<List<Operation>> SelectMonth(DateTime date)
        {
            List<Operation> output = new List<Operation>();
            List<Operation> input = new List<Operation>();
            List<Operation> total = new List<Operation>();

            using (WarrContext warrContext = new WarrContext())
            {
                input = warrContext.Operation.Where(operation => operation.Date.Month == date.Month && operation.Date.Year == date.Year && operation.Entry).OrderBy(operation => operation.Date).ToList();
                output = warrContext.Operation.Where(operation => operation.Date.Month == date.Month && operation.Date.Year == date.Year && !operation.Entry).OrderBy(operation => operation.Date).ToList();
            }
            List<List<Operation>> all = new List<List<Operation>>();
            all.Add(input);
            all.Add(output);
            total.AddRange(input);
            total.AddRange(output);
            total.OrderBy(operation => operation.Date).ToList();
            all.Add(total);
            return all;
        }
    }
}
