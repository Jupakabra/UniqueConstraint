using UniqueConstraint.Models;

namespace UniqueConstraint
{
    public class Program
    {
        public static void Main()
        {
            // Clean up
            Context context = new Context();
            context.RemoveRange(context.Set<Model>());
            context.RemoveRange(context.Set<Relation>());
            context.SaveChanges();

            // Insert initial data
            context.Add(new Model
            {
                Relation = new Relation
                {
                    Title = "Title"
                }
            });

            context.SaveChanges();

            // Try reinserting initial data with delete/insert

            context.RemoveRange(context.Set<Relation>());
            context.RemoveRange(context.Set<Model>());
            context.Add(new Model
            {
                Relation = new Relation
                {
                    Title = "Title"
                }
            });

            context.SaveChanges();
        }
    }
}
