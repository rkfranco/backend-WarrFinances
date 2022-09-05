using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class OperationRepository : BaseRepository<Operation>
    {
        public List<CategoryChart> GetAllGroupCategory()
        {
            List<CategoryChart> operations = new List<CategoryChart>();
            using (WarrContext warrContext = new WarrContext())
            {
                operations = warrContext.Operation
                    .Include("User")
                    .Include("Category")
                    .GroupBy(c=> new { c.Category.Name, c.Category.Color })
                    .Select(c => new CategoryChart{ 
                        Name = c.Key.Name, 
                        Color = c.Key.Color, 
                        Sum = c.Sum(x => x.Value) 
                    })
                    .ToList();
            }
            return operations;
        }

        public override List<Operation> GetAll()
        {
            List<Operation> operations = new List<Operation>();
            using (WarrContext warrContext = new WarrContext())
            {
                operations = warrContext.Operation.Include("User").Include("Category").ToList();
            }
            return operations;
        }

        public List<List<Operation>> SelectMonth(DateTime date, int userId)
        {
            List<Operation> output = new List<Operation>();
            List<Operation> input = new List<Operation>();
            List<Operation> total = new List<Operation>();

            using (WarrContext warrContext = new WarrContext())
            {
                input = warrContext.Operation.Include("Category").Where(operation => operation.Date.Month == date.Month && operation.Date.Year == date.Year && operation.Entry && operation.UserId == userId).OrderBy(operation => operation.Date).ToList();
                output = warrContext.Operation.Include("Category").Where(operation => operation.Date.Month == date.Month && operation.Date.Year == date.Year && !operation.Entry && operation.UserId == userId).OrderBy(operation => operation.Date).ToList();
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

        public Operation SelectById(int id)
        {

            Operation operation;
            using(WarrContext warrContext = new WarrContext())
            {
                operation = warrContext.Operation.Include("Category").Where(operation => operation.Id == id).FirstOrDefault();
            }
            return operation;
        }
    }
}
