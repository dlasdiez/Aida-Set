using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace DAL
{
  public class DBConnect
  {
    private MySqlConnection m_connection;
    private string m_server;
    private string m_database;
    private string m_puerto;
    private string m_uid;
    private string m_password;

    //Constructor
    public DBConnect(String Server, String Database, String Puerto, String User, String Password)
    {
      m_server = Server;
      m_database = Database;
      m_puerto = Puerto;
      m_uid = User;
      m_password = Password;

      Initialize();
    }

    #region Public Functions
    public Boolean IsOpen()
    {
      return this.OpenConnection();
    }

    //Insert statement
    public void Insert()
    {
      string query = "INSERT INTO articulos (titulo, age) VALUES('John Smith', '33')";

      //open connection
      if (this.OpenConnection() == true)
      {
        //create command and assign the query and connection from the constructor
        MySqlCommand cmd = new MySqlCommand(query, m_connection);

        //Execute command
        cmd.ExecuteNonQuery();

        //close connection
        this.CloseConnection();
      }
    }

    //Update statement
    public void Update()
    {
      string query = "UPDATE articulos SET titulo='Joe', age='22' WHERE titulo='John Smith'";

      //Open connection
      if (this.OpenConnection() == true)
      {
        //create mysql command
        MySqlCommand cmd = new MySqlCommand();
        //Assign the query using CommandText
        cmd.CommandText = query;
        //Assign the connection using Connection
        cmd.Connection = m_connection;

        //Execute query
        cmd.ExecuteNonQuery();

        //close connection
        this.CloseConnection();
      }
    }

    //Delete statement
    public void Delete()
    {
      string query = "DELETE FROM articulos WHERE titulo='John Smith'";

      if (this.OpenConnection() == true)
      {
        MySqlCommand cmd = new MySqlCommand(query, m_connection);
        cmd.ExecuteNonQuery();
        this.CloseConnection();
      }
    }

    public void ExecuteCreateDataBaseCommand(String Command)
    {
      try
      {
        if (this.OpenConnection() == true)
        {
          MySqlCommand cmd = new MySqlCommand(Command, m_connection);
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception _ex)
      {
        throw _ex;
      }
    }

    public void Close()
    {
      this.CloseConnection();
    }

    //Select statement
    public List<string>[] Select()
    {
      string query = "SELECT * FROM articulos";

      //Create a list to store the result
      List<string>[] list = new List<string>[3];
      list[0] = new List<string>();
      list[1] = new List<string>();
      list[2] = new List<string>();

      //Open connection
      if (this.OpenConnection() == true)
      {
        //Create Command
        MySqlCommand cmd = new MySqlCommand(query, m_connection);
        //Create a data reader and Execute the command
        MySqlDataReader dataReader = cmd.ExecuteReader();

        //Read the data and store them in the list
        while (dataReader.Read())
        {
          list[0].Add(dataReader["id"] + "");
          list[1].Add(dataReader["titulo"] + "");
          list[2].Add(dataReader["age"] + "");
        }

        //close Data Reader
        dataReader.Close();

        //close Connection
        this.CloseConnection();

        //return list to be displayed
        return list;
      }
      else
      {
        return list;
      }
    }

    //Count statement
    public int Count()
    {
      string query = "SELECT Count(*) FROM articulos";
      int Count = -1;

      //Open Connection
      if (this.OpenConnection() == true)
      {
        //Create Mysql Command
        MySqlCommand cmd = new MySqlCommand(query, m_connection);

        //ExecuteScalar will return one value
        Count = int.Parse(cmd.ExecuteScalar() + "");

        //close Connection
        this.CloseConnection();

        return Count;
      }
      else
      {
        return Count;
      }
    }

    //Backup
    public void Backup()
    {
      try
      {
        DateTime Time = DateTime.Now;
        int year = Time.Year;
        int month = Time.Month;
        int day = Time.Day;
        int hour = Time.Hour;
        int minute = Time.Minute;
        int second = Time.Second;
        int millisecond = Time.Millisecond;

        //Save file to C:\ with the current date as a filename
        string path;
        path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
        StreamWriter file = new StreamWriter(path);


        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "mysqldump";
        psi.RedirectStandardInput = false;
        psi.RedirectStandardOutput = true;
        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", m_uid, m_password, m_server, m_database);
        psi.UseShellExecute = false;

        Process process = Process.Start(psi);

        string output;
        output = process.StandardOutput.ReadToEnd();
        file.WriteLine(output);
        process.WaitForExit();
        file.Close();
        process.Close();
      }
      catch (IOException _ex)
      {
        throw _ex; //("Error , unable to backup!");
      }
    }

    //Restore
    public void Restore()
    {
      try
      {
        //Read file from C:\
        string path;
        path = "C:\\MySqlBackup.sql";
        StreamReader file = new StreamReader(path);
        string input = file.ReadToEnd();
        file.Close();


        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "mysql";
        psi.RedirectStandardInput = true;
        psi.RedirectStandardOutput = false;
        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", m_uid, m_password, m_server, m_database);
        psi.UseShellExecute = false;


        Process process = Process.Start(psi);
        process.StandardInput.WriteLine(input);
        process.StandardInput.Close();
        process.WaitForExit();
        process.Close();
      }
      catch (IOException _ex)
      {
        throw _ex; //("Error , unable to Restore!");
      }
    }
    #endregion

    #region Private Functions
    //Initialize values
    private void Initialize()
    {
      //m_server = "localhost";
      //m_database = "test";
      //m_uid = "jcalero";
      //m_password = "n3ww3b";
      string connectionString;
      connectionString = "SERVER=" + m_server + ";" + "PORT=" + m_puerto + ";" + "UID=" + m_uid + ";" + "PASSWORD=" + m_password + ";" + "DATABASE=" + m_database + ";";

      m_connection = new MySqlConnection(connectionString);
    }

    //open connection to database
    private bool OpenConnection()
    {
      try
      {
        m_connection.Open();
        return true;
      }
      catch (MySqlException _ex)
      {
        //When handling errors, you can your application's response based on the error number.
        //The two most common error numbers when connecting are as follows:
        //0: Cannot connect to server.
        //1045: Invalid user name and/or password.
        switch (_ex.Number)
        {
          case 0:
            throw new Exception("Cannot connect to server.  Contact administrator");
            break;

          case 1045:
            throw new Exception("Invalid username/password, please try again");
            break;
        }
        return false;
      }
    }

    //Close connection
    private bool CloseConnection()
    {
      try
      {
        m_connection.Close();
        return true;
      }
      catch (MySqlException _ex)
      {
        throw _ex;
        return false;
      }
    }
    #endregion

  }
}
