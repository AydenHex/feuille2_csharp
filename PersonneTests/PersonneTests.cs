
using System;
using Xunit;
using personnes;

namespace PersonneTests
{
    public class PersonneTestsClass
    {
        [Fact]
        public void CreateOnePerson()
        {
            Personne personne = new Personne("Test", "test", 1);
            Assert.Equal(Personne.Combien(), 1);
        }

        [Fact]
        public void CreateAndDisposePerson() 
        {
            Personne test1 = new Personne("Test", "test", 45);
            Assert.Equal(Personne.Combien(), 2);
            test1.Dispose();
            Assert.Equal(Personne.Combien(), 1);
        }
    }
}