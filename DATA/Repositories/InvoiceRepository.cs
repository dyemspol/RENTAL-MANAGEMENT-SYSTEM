using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RentalApp.Models.Core;

namespace RentalApp.Data.Repositories
{
    public class InvoiceRepository
    {
        // CREATE
        public int Add(Invoice invoice)
        {
            string sql = @"INSERT INTO Invoices 
                          (RentalID, IssueDate, RentalCharge, AppliedRateType, 
                           LateFee, DamageFee, FuelCharge, CleaningFee, TotalAmount, IsPaid) 
                          VALUES 
                          (@rentalId, @issue, @rental, @rateType, @late, @damage, @fuel, @clean, @total, @paid);
                          SELECT LAST_INSERT_ID();";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rentalId", invoice.RentalId);
                    cmd.Parameters.AddWithValue("@issue", invoice.IssueDate);
                    cmd.Parameters.AddWithValue("@rental", invoice.RentalCharge);
                    cmd.Parameters.AddWithValue("@rateType", invoice.AppliedRateType.HasValue ? invoice.AppliedRateType.Value.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@late", invoice.LateFee);
                    cmd.Parameters.AddWithValue("@damage", invoice.DamageFee);
                    cmd.Parameters.AddWithValue("@fuel", invoice.FuelCharge);
                    cmd.Parameters.AddWithValue("@clean", invoice.CleaningFee);
                    cmd.Parameters.AddWithValue("@total", invoice.TotalAmount);
                    cmd.Parameters.AddWithValue("@paid", invoice.IsPaid);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // READ
        public Invoice GetById(int id)
        {
            string sql = "SELECT * FROM Invoices WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToInvoice(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Invoice GetByRentalId(int rentalId)
        {
            string sql = "SELECT * FROM Invoices WHERE RentalID = @rentalId";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rentalId", rentalId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToInvoice(reader);
                        }
                    }
                }
            }
            return null;
        }

        public List<Invoice> GetUnpaid()
        {
            List<Invoice> invoices = new List<Invoice>();
            string sql = @"SELECT i.*, 
                                  CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                                  CONCAT(v.Make, ' ', v.Model, ' (', v.Year, ')') as VehicleInfo,
                                  CONCAT(u.Firstname, ' ', u.Lastname) as AgentName
                           FROM Invoices i
                           LEFT JOIN Rentals r ON i.RentalID = r.ID
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users u ON r.RentalAgentId = u.ID
                           WHERE i.IsPaid = FALSE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoices.Add(MapReaderToInvoice(reader));
                        }
                    }
                }
            }
            return invoices;
        }
        public List<Invoice> GetAllPaid()
        {
            List<Invoice> invoices = new List<Invoice>();
            string sql = @"SELECT i.*, 
                                  CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                                  CONCAT(v.Make, ' ', v.Model, ' (', v.Year, ')') as VehicleInfo,
                                  CONCAT(u.Firstname, ' ', u.Lastname) as AgentName
                           FROM Invoices i
                           LEFT JOIN Rentals r ON i.RentalID = r.ID
                           LEFT JOIN Customers c ON r.CustomerID = c.ID
                           LEFT JOIN Vehicles v ON r.VehicleID = v.ID
                           LEFT JOIN Users u ON r.RentalAgentId = u.ID
                           WHERE i.IsPaid = TRUE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoices.Add(MapReaderToInvoice(reader));
                        }
                    }
                }
            }
            return invoices;
        }

        // UPDATE
        public void Update(Invoice invoice)
        {
            string sql = @"UPDATE Invoices SET 
                          RentalCharge = @rental, LateFee = @late, DamageFee = @damage,
                          FuelCharge = @fuel, CleaningFee = @clean, TotalAmount = @total, IsPaid = @paid
                          WHERE ID = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", invoice.Id);
                    cmd.Parameters.AddWithValue("@rental", invoice.RentalCharge);
                    cmd.Parameters.AddWithValue("@late", invoice.LateFee);
                    cmd.Parameters.AddWithValue("@damage", invoice.DamageFee);
                    cmd.Parameters.AddWithValue("@fuel", invoice.FuelCharge);
                    cmd.Parameters.AddWithValue("@clean", invoice.CleaningFee);
                    cmd.Parameters.AddWithValue("@total", invoice.TotalAmount);
                    cmd.Parameters.AddWithValue("@paid", invoice.IsPaid);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int CountToday()
        {
            string sql = "SELECT COUNT(*) FROM Invoices WHERE DATE(IssueDate) = CURDATE()";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public decimal SumInvoicedToday()
        {
            string sql = "SELECT IFNULL(SUM(TotalAmount), 0) FROM Invoices WHERE DATE(IssueDate) = CURDATE() AND IsPaid = TRUE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        public decimal SumRevenue()
        {
            string sql = "SELECT IFNULL(SUM(TotalAmount), 0) FROM Invoices WHERE IsPaid = TRUE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        // HELPER
        private Invoice MapReaderToInvoice(MySqlDataReader reader)
        {
            var invoice = new Invoice
            {
                Id = reader.GetInt32("ID"),
                RentalId = reader.GetInt32("RentalID"),
                IssueDate = reader.GetDateTime("IssueDate"),
                RentalCharge = reader.GetDecimal("RentalCharge"),
                AppliedRateType = reader.IsDBNull(reader.GetOrdinal("AppliedRateType")) ? (RateType?)null : (RateType)Enum.Parse(typeof(RateType), reader.GetString("AppliedRateType")),
                LateFee = reader.GetDecimal("LateFee"),
                DamageFee = reader.GetDecimal("DamageFee"),
                FuelCharge = reader.GetDecimal("FuelCharge"),
                CleaningFee = reader.GetDecimal("CleaningFee"),
                TotalAmount = reader.GetDecimal("TotalAmount"),
                IsPaid = reader.GetBoolean("IsPaid")
            };

            // Map Extra Fields from JOINs if they exist
            try
            {
                if (!reader.IsDBNull(reader.GetOrdinal("CustomerName")))
                    invoice.CustomerName = reader.GetString("CustomerName");
                
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleInfo")))
                    invoice.VehicleInfo = reader.GetString("VehicleInfo");
                
                if (!reader.IsDBNull(reader.GetOrdinal("AgentName")))
                    invoice.RentalAgentName = reader.GetString("AgentName");
            }
            catch { /* Columns not in result set */ }

            return invoice;
        }
        
    }
}
