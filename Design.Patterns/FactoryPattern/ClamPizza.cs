namespace FactoryPattern
{
    public class ClamPizza : Pizza
    {
        public override void prepare()
        {
            throw new System.NotImplementedException();
        }

        public override void bake()
        {
            throw new System.NotImplementedException();
        }

        public override void cut()
        {
            throw new System.NotImplementedException();
        }

        public override void box()
        {
            throw new System.NotImplementedException();
        }
    }
}