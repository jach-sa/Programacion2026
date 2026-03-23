/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package itr;
//BIBLIOTECA DE LA INTERFAZ GRAFICA
import java.awt.Color;
import javax.swing.JFrame;
import javax.swing.JLabel;
/**
 *
 * @author jachr
 * CONSTRUCOR DE CLASE DEFINE LAS CARACTERISTICAS DE LA VENTANA
 */ 
public class VentanaPrincipaal extends JFrame{
    //DEFINE LA VENTANA
    public JLabel etiqueta;
    public VentanaPrincipaal(){
        //TITULO DE LA VENTANA
        this.setTitle ("Para cambiar el titulo");
        //DIMENSIONES
        this.setSize(400,400);
        //BLOQUEA LA POSIBILIDAD DE CAMBIOS
        this.setResizable(false);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //ASEGURA QUE EL PROGRAMA NO CONSUMA MEMORIA DESPUES DE CERRARLO
        
        this.getContentPane().setLayout(null);
        this.getContentPane().setBackground(Color.white);
        //CONFIGURACION DE LOS ELEMENTOS
        etiqueta=new JLabel ("HOLA MUNDO");
        etiqueta.setBackground(Color.RED);
        etiqueta.setBounds(40,40,80,80);
        etiqueta.setOpaque(true);
        this.getContentPane().add(etiqueta);
        
    }
}
