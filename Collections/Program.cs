using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Group> listGroup = new List<Group>();
            var group1 = new Group();
            group1.Name = "Fatima";
            var group2 = new Group();
            group2.Name = "Azer";
            var group3 = new Group();
            group3.Name = "Azer";

            AddGroup(listGroup, group1);
            AddGroup(listGroup, group2);
            AddGroup(listGroup, group3);

            foreach (var group in listGroup)
            {
                Console.WriteLine(group.GetDetails());
            }
            


            static void AddGroup (List<Group> listGroup, Group group)
            {
                var dublicateName = listGroup.Any(g => g.Name == group.Name);
                if (!dublicateName) 
                {
                   listGroup.Add(group);
                }

                
            }



        }
    }
}