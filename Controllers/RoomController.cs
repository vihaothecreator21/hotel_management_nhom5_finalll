using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Implementations;
using hotel_management_nhom5.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace hotel_management_nhom5.Controllers
{
    public class RoomController : IRoomRepository
    {
        private readonly string connectionString;
        private readonly IRoomRepository _roomRepository;

        public RoomController()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string 'MyConnection' not found.");
        }

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string 'MyConnection' not found.");
        }

        public IEnumerable<Room> GetAll()
        {
            var room = _roomRepository.GetAll();
            return room;
        }

        public IEnumerable<Room> GetStatus()
        {
            throw new NotImplementedException();
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Room room) => _roomRepository.Update(room);

        public List<(string RoomNumber, string Type, string ImageKey, string Status, decimal Price, int Capacity, string Description)> GetRoomList()
        {
            var list = new List<(string, string, string, string, decimal, int, string)>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomNumber, Type, ImageKey, Status, Price, Capacity, Description FROM Rooms";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string roomNumber = reader["RoomNumber"].ToString();
                    string type = reader["Type"].ToString();
                    string imageKey = reader["ImageKey"].ToString();
                    string status = reader["Status"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    int capacity = Convert.ToInt32(reader["Capacity"]);
                    string description = reader["Description"].ToString();

                    list.Add((roomNumber, type, imageKey, status, price, capacity, description));
                }
            }

            return list;
        }

        public IEnumerable<Room> GetAvailable()
        {
            throw new NotImplementedException();
        }

        public void Add(Room room) => _roomRepository.Add(room);

        public void Delete(int id) => _roomRepository.Delete(id);
    }
}