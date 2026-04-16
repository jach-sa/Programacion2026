/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package telasdeOtono;
import java.sql.*;
/**
 *
 * @author Abyvi
 */
public class dbConnection {
      static String url="jdbc:mysql://localhost:3306/TelasDeOtono";
           static  String user="root";
           static  String pass="12345678n";
             
             public static Connection conectar()
             {
                 Connection con=null;
                 try
                 {
                     con=DriverManager.getConnection(url,user,pass);
                     System.out.print("COnexion exitosa");
                 }catch(SQLException e)
                 {
                  e.printStackTrace();
                 }
             return con;
             
             }
  
    public static void main(String[] args) {
        conectar(); 
}
             
}
