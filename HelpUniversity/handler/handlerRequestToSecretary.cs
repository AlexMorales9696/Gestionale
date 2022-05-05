using People;


namespace Secretary
{
    internal class handlerRequestToSecretary
    {
      
        public IEnumerable<Person> GetPersone(string cognome)
        {
            var persister = new RequestToSecretary();
            var ListPerson = persister.GetPeople(cognome);
            return ListPerson;
        }

        public IEnumerable<Person> GetTeacher()
        {
            var persister = new RequestToSecretary();
            var ListPerson = persister.GetTachers();
            return ListPerson;
        }

        public IEnumerable<Person> StampaLePersone()
        {
            var persister = new RequestToSecretary();
            var ListPerson = persister.GetPeople();
            return ListPerson;
        }


      
    }
}
