namespace Case07.Model
{
    public class Divider
    {
        private readonly decimal _lhs;
        private readonly decimal _rhs;

        public Divider(decimal lhs, decimal rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        public decimal Execute()
        {
            return _lhs / _rhs;
        }
    }
}
