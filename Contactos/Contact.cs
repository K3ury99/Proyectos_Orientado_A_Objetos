namespace Contactos.Contact
{
    public class Contactos // Datos fijos
    {
        public int Ids { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contactos()
        {
            this.Name = "";
            this.Phone = "";
            this.Email = "";
            this.Address = "";
        }
    }

    public class Agenda // Manipulacion de los datos "Contactos"
    {
        private List<Contactos> contactos = new List<Contactos>();

        public void AddContact() // Agrega los contactos
        {
            Contactos newContact = new Contactos();

            int id = contactos.Count + 1;
            newContact.Ids = id;

            // Solicitar el nombre y validar que no sea nulo o vacío
            do
            {
                Console.Write("\n-Ingrese el nombre: ");
                newContact.Name = Console.ReadLine()??"";
                if (string.IsNullOrEmpty(newContact.Name))
                {
                    Console.WriteLine("El nombre no puede estar vacío...");
                }
            } while (string.IsNullOrEmpty(newContact.Name));

            // Solicitar el teléfono y validar que no sea nulo o vacío
            do
            {
                Console.Write("-Ingrese el teléfono: ");
                newContact.Phone = Console.ReadLine()??"";
                if (string.IsNullOrEmpty(newContact.Phone))
                {
                    Console.WriteLine("El teléfono no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(newContact.Phone));


            Console.Write("-Ingrese el correo electrónico: ");
            newContact.Email = Console.ReadLine()??"";

            Console.Write("-Ingrese la dirección: ");
            newContact.Address = Console.ReadLine()??"";

            // Agregar el nuevo contacto a la lista
            contactos.Add(newContact);

            Console.WriteLine("\n---Contacto agregado correctamente.\n");
        }

        public void ViewContacts() // Visualiza todos los contactos
        {
            Console.WriteLine("\n--Lista de Contactos:");
            foreach (var contact in contactos)
            {
                Console.WriteLine($"ID: {contact.Ids}, Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}");
            }
            Console.WriteLine();
        }

        public void EditContact() // Edita los contactos
        {
            string editName;
            do
            {
                Console.Write("\n-Ingrese el nombre del contacto a editar: ");
                editName = Console.ReadLine()??"";
                if (string.IsNullOrEmpty(editName))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(editName));

            var contact = contactos.Find(c => c.Name.Equals(editName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                Console.WriteLine($"Editando contacto - Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}");

            do
            {
                Console.Write("\n-Ingrese el nombre: ");
                contact.Name = Console.ReadLine()??"";
                if (string.IsNullOrEmpty(contact.Name))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(contact.Name));

            do
            {
                Console.Write("\n-Ingrese el telefono: ");
                contact.Phone = Console.ReadLine()??"";
                if (string.IsNullOrEmpty(contact.Phone))
                {
                    Console.WriteLine("El telefono no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(contact.Phone));

                Console.Write("-Nuevo correo electrónico: ");
                contact.Email = Console.ReadLine()??"";

                Console.Write("-Nueva dirección: ");
                contact.Address = Console.ReadLine()??"";

                Console.WriteLine("-Contacto editado correctamente.\n");
            }
            else
            {
                Console.WriteLine("-Contacto no encontrado.\n");
            }
        }

        public void DeleteContact() // Borra los contactos
        {
            Console.Write("\n---Ingrese el nombre del contacto a eliminar: ");
            string deleteName = Console.ReadLine() ??"";

            var contact = contactos.Find(c => c.Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                contactos.Remove(contact);
                Console.WriteLine("\n---Contacto eliminado correctamente.\n");
            }
            else
            {
                Console.WriteLine("\n---Contacto no encontrado.\n");
            }
        }

        public void SearchContact() // Busca los contactos dependiendo la opcion seleccionada
        {
            Console.WriteLine("\n---Opciones de búsqueda---");
            Console.WriteLine("1. Buscar por Nombre");
            Console.WriteLine("2. Buscar por Teléfono");
            Console.WriteLine("3. Buscar por Email");
            Console.WriteLine("4. Buscar por Dirección");
            Console.Write("Seleccione una opción: ");

            int searchOption = Convert.ToInt32(Console.ReadLine());

            switch (searchOption)
            {
                case 1:
                    SearchByName();
                    break;
                case 2:
                    SearchByPhone();
                    break;
                case 3:
                    SearchByEmail();
                    break;
                case 4:
                    SearchByAddress();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        private void SearchByName() 
        {
            string searchName;
            do
            {
                Console.Write("\n--Ingrese el nombre del contacto a buscar: ");
                searchName = Console.ReadLine()??"";
                
                if (string.IsNullOrEmpty(searchName))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(searchName));

            var matchingContacts = contactos.FindAll(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (matchingContacts.Count > 0)
            {
                Console.WriteLine("\n--Contactos encontrados:");
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"ID: {contact.Ids}, Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}\n");
                }
            }
            else
            {
                Console.WriteLine("\n--Contacto no encontrado.\n");
            }
        }

        private void SearchByPhone()
        {
            string searchPhone;
            do
            {
                Console.Write("\n--Ingrese el telefono del contacto a buscar: ");
                searchPhone = Console.ReadLine()??"";
                
                if (string.IsNullOrEmpty(searchPhone))
                {
                    Console.WriteLine("El telefono no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(searchPhone));

            var matchingContacts = contactos.FindAll(c => c.Phone.Equals(searchPhone));

            if (matchingContacts.Count > 0)
            {
                Console.WriteLine("\n--Contactos encontrados:");
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"ID: {contact.Ids}, Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}\n");
                }
            }
            else
            {
                Console.WriteLine("--Contacto no encontrado.\n");
            }
        }

        private void SearchByEmail()
        {
            Console.Write("--Ingrese el correo electrónico del contacto a buscar: ");
            string searchEmail = Console.ReadLine() ?? "";

            var matchingContacts = contactos.FindAll(c => c.Email.Equals(searchEmail, StringComparison.OrdinalIgnoreCase));

            if (matchingContacts.Count > 0)
            {
                Console.WriteLine("\n--Contactos encontrados:");
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"ID: {contact.Ids}, Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}\n");
                }
            }
            else
            {
                Console.WriteLine("\n--Contacto no encontrado.\n");
            }
        }

        private void SearchByAddress()
        {
            Console.Write("--Ingrese la dirección del contacto a buscar: ");
            string searchAddress = Console.ReadLine() ??"";

            var matchingContacts = contactos.FindAll(c => c.Address.Equals(searchAddress, StringComparison.OrdinalIgnoreCase));

            if (matchingContacts.Count > 0)
            {
                Console.WriteLine("\n--Contactos encontrados:");
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"ID: {contact.Ids}, Nombre: {contact.Name}, Teléfono: {contact.Phone}, Email: {contact.Email}, Dirección: {contact.Address}\n");
                }
            }
            else
            {
                Console.WriteLine("\n--Contacto no encontrado.\n");
            }
        }
    }
}
