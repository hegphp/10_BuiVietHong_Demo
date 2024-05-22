using _10_BuiVietHong_Demo24Update.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _10_BuiVietHong_Demo24Update.Services
{
    class ManageContact
    {
        string fileName = "ContactList.json";
        List<Contact> contacts = new List<Contact>();
        public ManageContact() { 
        }
        //Load contacts list from file
        public void LoadContacts()
        {
            try
            {
                string json = File.ReadAllText(fileName);
                contacts = JsonSerializer.Deserialize<List<Contact>>(json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Save contacts list to file
        public void SaveContactListToFile()
        {
            try
            {
                //Serialize the list of contacts to json string
                string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true                                                                                                       });
                //Write the json string to file
                File.WriteAllText(fileName, json);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        //Add new contact
        public void AddNewContact(Contact contact)
        {
            try
            {
                //Check if the contact is existed or not
                Contact c = contacts.SingleOrDefault(c => c.ContactID == contact.ContactID);
                if (c != null)
                {
                    throw new Exception("Contact is existed");
                }
                contacts.Add(contact);
                SaveContactListToFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Update contact
        public void UpdateContact(Contact contact)
        {
            try
            {
                //Check if the contact is existed or not
                Contact c = contacts.SingleOrDefault(c => c.ContactID == contact.ContactID);
                if (c == null)
                {
                    throw new Exception("Contact is not existed");
                }
                //Update the contact
                c.ContactName = contact.ContactName;
                c.Phone = contact.Phone;
                c.CompanyName = contact.CompanyName;
                SaveContactListToFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Delete contact by id
        public void DeleteContact(string contactId)
        {
            try
            {
                //Check if the contact is existed or not
                Contact c = contacts.SingleOrDefault(c => c.ContactID == contactId);
                if (c == null)
                {
                    throw new Exception("Contact is not existed");
                }
                contacts.Remove(c);
                SaveContactListToFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Get all contacts
        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
