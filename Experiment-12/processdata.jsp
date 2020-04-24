<%@ page language="java" import="java.sql.*"%> <% 
String name = request.getParameter("uname"); 
String email = request.getParameter("uemail");
String pass = request.getParameter("upass");
String dob = request.getParameter("udob");
String gender = request.getParameter("ugender");
String phone = request.getParameter("uphone");
String country = request.getParameter("uloc"); 
String role = request.getParameter("urole"); 
try {
Class.forName("oracle.jdbc.driver.OracleDriver"); 
Connection con = DriverManager.getConnection("jdbc:oracle:thin:@mcndesktop07:1521:XE", "sandeep","welcome");
PreparedStatement ps = con.prepareStatement("insert into regvalues(?,?,?,?,?,?,?)"); 
ps.setString(1, name); ps.setString(2, email);
ps.setString(3, pass); ps.setString(4, dob); ps.setString(5, gender);
ps.setString(6, phone); ps.setString(7, country); ps.executeUpdate();
out.println("Data saved successfully"); } catch (Exception e) { out.println(e);
} %>
