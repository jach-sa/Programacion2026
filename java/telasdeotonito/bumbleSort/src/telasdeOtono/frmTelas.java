/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package telasdeOtono;

import javax.swing.JOptionPane;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.table.DefaultTableModel;
/**
 *
 * @author Abyvi
 */
public class frmTelas extends javax.swing.JFrame {
    boolean errorMostrado = false;
    /**
     * Creates new form frmTelas
     */
    public frmTelas() {
        getContentPane().setBackground(new java.awt.Color(110, 44, 65)); 
        initComponents();
        llenaPrendas();
    mostrarVentas();
    }
//1
    void llenaPrendas(){
        cboPrenda.removeAllItems();
        cboPrenda.addItem("Pantalones de Lana");
        cboPrenda.addItem("Sueter de casimir");
        cboPrenda.addItem("Blusa de seda");
        cboPrenda.addItem("Camisola de seda");
        cboPrenda.addItem("Falda recta");
        cboPrenda.addItem("Saco de lana");
        
    }
    //2
   int getPrenda(){
    return cboPrenda.getSelectedIndex();
}
//3
int getCantidad(){
    try {
        return Integer.parseInt(txtCantidad.getText());
    } catch (NumberFormatException e) {
        JOptionPane.showMessageDialog(this,
            "Entrada no válida. Por favor, ingrese únicamente valores numéricos en el campo de cantidad.",
            "Error de validación",
            JOptionPane.WARNING_MESSAGE);

        txtCantidad.setText("");
        txtCantidad.requestFocus();
        throw e; 
    }
}
    //4
    double asignaPrecio(){
        switch(getPrenda()){
            case 0: return 45;
             case 1: return 100;
              case 2: return 14;
               case 3: return 10;
                case 4: return 40;
                 default: return 120;
            
        }
    }
    //5
    double calculaMonto(){
        return getCantidad()*asignaPrecio();
        
    }
    //6
    double calcularDescuento(){
        if (calculaMonto()<=100)
            return 0.02*calculaMonto();
        else if  (calculaMonto()<=500)
            return 0.04*calculaMonto();
        else if (calculaMonto()<=1000)
            return 0.06*calculaMonto();
        else if (calculaMonto()<=1500)
            return 0.08*calculaMonto();
        else
            return 0.20*calculaMonto();
                    }
    //7
    double calculaNeto(){
      return calculaMonto() - calcularDescuento();
      
    }
    //8
    double calculaIVA(){
    return calculaNeto() * 0.18;
    }
    //9
    void imprimir(){
        txtR.setText("");
        txtR.append("Prenda :"+cboPrenda.getSelectedItem());
        txtR.append("\nCantidad:"+getCantidad());
        txtR.append("\nPrecio: $"+asignaPrecio());
        txtR.append("\n--------------------------------------------");
        txtR.append("\nEl monto a pagar es: $"+
                String.format("%.2f", calculaMonto()));
        txtR.append("\nEl monto de dscuento es: $"+
                String.format("%.2f", calcularDescuento()));
        txtR.append("\nEl Monto Neto es: $"+
                String.format("%.2f", calculaNeto()));
    }
    
    void guardarVenta() {
    try {
        Connection cn = DriverManager.getConnection(
            "jdbc:mysql://localhost/TelasDeOtono", "root", "12345678n");

        String sql = "INSERT INTO ventas (prenda, cantidad, precio, monto, descuento, neto, iva, total) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

        PreparedStatement ps = cn.prepareStatement(sql);

        ps.setString(1, cboPrenda.getSelectedItem().toString());
        ps.setInt(2, getCantidad());
        ps.setDouble(3, asignaPrecio());
        ps.setDouble(4, calculaMonto());
        ps.setDouble(5, calcularDescuento());
        ps.setDouble(6, calculaNeto());
        ps.setDouble(7, chkIVA.isSelected() ? calculaIVA() : 0);
        ps.setDouble(8, calculaNeto() + (chkIVA.isSelected() ? calculaIVA() : 0));

        ps.executeUpdate();

    } catch (Exception e) {
        e.printStackTrace();
    }
}
    void mostrarVentas() {
    try {
        Connection cn = DriverManager.getConnection(
            "jdbc:mysql://localhost/TelasDeOtono", "root", "12345678n");

        String sql = "SELECT * FROM ventas";
        PreparedStatement ps = cn.prepareStatement(sql);
        ResultSet rs = ps.executeQuery();

        DefaultTableModel modelo = new DefaultTableModel();
        modelo.addColumn("Prenda");
        modelo.addColumn("Cantidad");
        modelo.addColumn("Precio");
        modelo.addColumn("Monto");
        modelo.addColumn("Descuento");
        modelo.addColumn("Neto");
        modelo.addColumn("IVA");
        modelo.addColumn("Total");

        while (rs.next()) {
            Object[] fila = new Object[8];
            fila[0] = rs.getString("prenda");
            fila[1] = rs.getInt("cantidad");
            fila[2] = rs.getDouble("precio");
            fila[3] = rs.getDouble("monto");
            fila[4] = rs.getDouble("descuento");
            fila[5] = rs.getDouble("neto");
            fila[6] = rs.getDouble("iva");
            fila[7] = rs.getDouble("total");

            modelo.addRow(fila);
        }

        tblVentas.setModel(modelo);

    } catch (Exception e) {
        e.printStackTrace();
    }
}
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jOptionPane1 = new javax.swing.JOptionPane();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        cboPrenda = new javax.swing.JComboBox<>();
        btnCalcular = new javax.swing.JButton();
        btnLimpiar = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtR = new javax.swing.JTextArea();
        chkIVA = new javax.swing.JCheckBox();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtCantidad = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        tblVentas = new javax.swing.JTable();
        btnGuardar = new javax.swing.JButton();

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane2.setViewportView(jTable1);

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setAutoRequestFocus(false);
        setBackground(new java.awt.Color(255, 255, 105));
        getContentPane().setLayout(null);

        jLabel1.setFont(new java.awt.Font("Segoe UI", 0, 24)); // NOI18N
        jLabel1.setText("TELAS Y MODA DE OTOÑO");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(310, 30, 450, 40);

        cboPrenda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        cboPrenda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cboPrendaActionPerformed(evt);
            }
        });
        getContentPane().add(cboPrenda);
        cboPrenda.setBounds(100, 100, 110, 26);

        btnCalcular.setText("CALCULAR");
        btnCalcular.setBorder(javax.swing.BorderFactory.createEtchedBorder(java.awt.Color.blue, null));
        btnCalcular.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCalcularActionPerformed(evt);
            }
        });
        getContentPane().add(btnCalcular);
        btnCalcular.setBounds(110, 150, 90, 30);

        btnLimpiar.setText("LIMPIAR");
        btnLimpiar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLimpiarActionPerformed(evt);
            }
        });
        getContentPane().add(btnLimpiar);
        btnLimpiar.setBounds(300, 150, 110, 24);

        btnSalir.setText("SALIR");
        btnSalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSalirActionPerformed(evt);
            }
        });
        getContentPane().add(btnSalir);
        btnSalir.setBounds(124, 380, 90, 24);

        txtR.setColumns(20);
        txtR.setRows(5);
        txtR.addContainerListener(new java.awt.event.ContainerAdapter() {
            public void componentAdded(java.awt.event.ContainerEvent evt) {
                txtRComponentAdded(evt);
            }
        });
        jScrollPane1.setViewportView(txtR);

        getContentPane().add(jScrollPane1);
        jScrollPane1.setBounds(120, 220, 270, 130);

        chkIVA.setText("IVA");
        chkIVA.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                chkIVAItemStateChanged(evt);
            }
        });
        chkIVA.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                chkIVAActionPerformed(evt);
            }
        });
        getContentPane().add(chkIVA);
        chkIVA.setBounds(410, 360, 93, 24);

        jLabel2.setText("Seleccione Prenda");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(90, 80, 110, 16);

        jLabel3.setText("Ingrese Cantidad");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(300, 80, 100, 16);

        txtCantidad.setText("5");
        getContentPane().add(txtCantidad);
        txtCantidad.setBounds(300, 100, 90, 24);

        jLabel4.setText("Resumenes de la Venta");
        getContentPane().add(jLabel4);
        jLabel4.setBounds(120, 200, 130, 16);

        tblVentas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane3.setViewportView(tblVentas);

        getContentPane().add(jScrollPane3);
        jScrollPane3.setBounds(550, 110, 310, 150);

        btnGuardar.setText("GUARDAR");
        btnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarActionPerformed(evt);
            }
        });
        getContentPane().add(btnGuardar);
        btnGuardar.setBounds(280, 380, 100, 24);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnLimpiarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLimpiarActionPerformed
       txtCantidad.setText("");
        txtR.setText("");
         cboPrenda.setSelectedIndex(0);
           chkIVA.setSelected(false);        
    }//GEN-LAST:event_btnLimpiarActionPerformed

    private void btnSalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSalirActionPerformed
        int r = JOptionPane.showOptionDialog(
            this,
            "¿Estas seguro de salir...?",
            "Telas y moda de Otoño",
            JOptionPane.YES_NO_OPTION,
            JOptionPane.QUESTION_MESSAGE,
            null,
            null,
            null);

    if (r == JOptionPane.YES_OPTION) {
        System.exit(0);
    }
    }//GEN-LAST:event_btnSalirActionPerformed

    private void txtRComponentAdded(java.awt.event.ContainerEvent evt) {//GEN-FIRST:event_txtRComponentAdded
        // TODO add your handling code here:
    }//GEN-LAST:event_txtRComponentAdded

    private void chkIVAActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_chkIVAActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_chkIVAActionPerformed

    private void btnCalcularActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCalcularActionPerformed
imprimir();
    }//GEN-LAST:event_btnCalcularActionPerformed

    private void chkIVAItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_chkIVAItemStateChanged
     if (chkIVA.isSelected()){
        imprimir();
        txtR.append("\nEl monto es: $"+
                String.format("%.2f", calculaIVA()));
     }else{
         imprimir();
     }
    }//GEN-LAST:event_chkIVAItemStateChanged

    private void cboPrendaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cboPrendaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cboPrendaActionPerformed

    private void btnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarActionPerformed
                                           
    guardarVenta();
    mostrarVentas();
    JOptionPane.showMessageDialog(this, "Venta guardada correctamente");
    }//GEN-LAST:event_btnGuardarActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frmTelas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmTelas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmTelas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmTelas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmTelas().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCalcular;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JButton btnLimpiar;
    private javax.swing.JButton btnSalir;
    private javax.swing.JComboBox<String> cboPrenda;
    private javax.swing.JCheckBox chkIVA;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JOptionPane jOptionPane1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTable jTable1;
    private javax.swing.JTable tblVentas;
    private javax.swing.JTextField txtCantidad;
    private javax.swing.JTextArea txtR;
    // End of variables declaration//GEN-END:variables
}
