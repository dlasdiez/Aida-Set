using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBJ;
using MySql.Data.MySqlClient;

namespace DAL
{
  public class DalExpediente
  {
    public Boolean Select(Int64 Id, out ObjExpediente ObjExpediente)
    {
      ObjExpediente = new ObjExpediente();

      try
      {

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Insert(ObjExpediente ObjExpediente)
    {
      try
      {
        //MySqlCommand cmd = new MySqlCommand();
        //cmd.Connection = conn;

        //cmd.CommandText = "INSERT INTO room(person,address) VALUES(?person,?address)";
        //cmd.Parameters.Add("?person", MySqlDbType.VarChar).Value = "myname";
        //cmd.Parameters.Add("?address", MySqlDbType.VarChar).Value = "myaddress";
        //cmd.ExecuteNonQuery();

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Update(ObjExpediente ObjExpediente)
    {
      try
      {

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Delete(ObjExpediente ObjExpediente)
    {
      try
      {

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

  }


}
