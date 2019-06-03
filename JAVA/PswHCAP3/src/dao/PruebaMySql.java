package dao;

import java.sql.*;

public class PruebaMySql {

    public static void main(String[] args) {
        /**
         * 3306 puerto para MySQL en XAMPP
         */
        String url = "jdbc:mysql://localhost:3306/";
        String user = "root";
        String password = "";
        
        try {
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            Connection con = DriverManager.getConnection(url, user, password);
            
            Statement stt = con.createStatement();
            
            stt.execute("CREATE DATABASE IF NOT EXISTS test");
            stt.execute("USE test");
            
            stt.execute("DROP TABLE IF EXISTS persona");
            stt.execute("CREATE TABLE persona (" +
                    "id BIGINT NOT NULL AUTO_INCREMENT,"
                    + "nombre VARCHAR(25),"
                    + "apPaterno VARCHAR(25),"
                    + "PRIMARY KEY(id)"
                    + ")");
            
            stt.execute("INSERT INTO persona (nombre, apPaterno) VALUES" + 
                    "('Harim', 'Castellanos'), ('John', 'Carter'), ('Rayo', 'MacQueen')");
            
            ResultSet res = 
                    stt.executeQuery("SELECT * FROM persona WHERE apPaterno = 'Castellanos'");
            
            while (res.next()) {
                System.out.println(res.getString("nombre") + " " + res.getString("apPaterno"));
            }
            System.out.println("");
            
            PreparedStatement prep = 
                    con.prepareStatement("SELECT * FROM persona WHERE apPaterno = ?");
            prep.setString(1, "Castellanos");
            
            res = prep.executeQuery();
            while (res.next()) {
                System.out.println(res.getString("nombre") + " " + res.getString("apPaterno"));
            }
            
            res.close();
            stt.close();
            prep.close();
            con.close();
            
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
