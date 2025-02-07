namespace HelloWorldMVCApplication.Models
{
    public class ContactRepository
    {
        private string connectionString = "@variableConnectionString"; // Replace with your connection string

        public ContactModel GetContactById(int id)
        {
            ContactModel contact = null;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string query = "SELECT FirstName, LastName FROM Contacts WHERE Id = @Id";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@Id", id);
            //        connection.Open();

            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                contact = new ContactModel
            //                {
            //                    FirstName = reader["FirstName"].ToString(),
            //                    LastName = reader["LastName"].ToString()
            //                };
            //            }
            //        }
            //    }
            //}

            contact = new ContactModel
            {
                FirstName = "Joe",
                LastName = "Nguyen"
            };

            return contact;
        }
    }

}