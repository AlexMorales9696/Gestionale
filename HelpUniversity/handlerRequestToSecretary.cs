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
    }
}
