namespace Library
{
    public class AgeVisitor : AbstractVisitor
    {
        public override int TotalAgeVisitor(Node n)
        {
            int totalAge = n.person.Age;
            foreach (Node node in n.Children)
            {
                totalAge = totalAge + node.person.Age;
            }
            return totalAge;
        }
    }
}