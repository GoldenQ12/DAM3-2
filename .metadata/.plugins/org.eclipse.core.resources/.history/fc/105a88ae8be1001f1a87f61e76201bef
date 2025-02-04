package vistasBD;

import java.awt.BorderLayout;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import controladoresBD.AddressController;
import controladoresBD.CustomerController;
import modelosBD.Customer;

import java.awt.Font;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTable;
import javax.swing.JScrollPane;

public class MostrarClientesPorPais extends JDialog {

	private static final long serialVersionUID = 1L;
	private final JPanel contentPanel = new JPanel();
	private JTable table;
	private CustomerController customer = new CustomerController();
	private AddressController addresses = new AddressController();
	private static int id = 0;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		try {
			MostrarClientesPorPais dialog = new MostrarClientesPorPais(id);
			dialog.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
			dialog.setVisible(true);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	/**
	 * Create the dialog.
	 */
	public MostrarClientesPorPais(int id_pais) {
		id = id_pais;
		setBounds(100, 100, 879, 536);
		getContentPane().setLayout(new BorderLayout());
		contentPanel.setBorder(new EmptyBorder(5, 5, 5, 5));
		getContentPane().add(contentPanel, BorderLayout.CENTER);
		contentPanel.setLayout(null);
		
		JButton btnVolver = new JButton("VOLVER");
		btnVolver.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int respuesta = JOptionPane.showConfirmDialog(
						null, 
						"Seguro que quieres volver?", 
						"Confirmación", 
						JOptionPane.YES_NO_OPTION, 
						JOptionPane.QUESTION_MESSAGE);
				if (respuesta == JOptionPane.YES_OPTION) {
					dispose();
				}	
			}
		});
		btnVolver.setForeground(Color.RED);
		btnVolver.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnVolver.setBounds(693, 402, 160, 84);
		contentPanel.add(btnVolver);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 36, 648, 404);
		contentPanel.add(scrollPane);
		
		table = new JTable();
		 scrollPane.setViewportView(table);
	        DefaultTableModel modelo = (DefaultTableModel) table.getModel();
	        modelo.addColumn("ID");
	        modelo.addColumn("Tienda");
	        modelo.addColumn("Primer apellido");
	        modelo.addColumn("Segundo apellido");
	        modelo.addColumn("Mail");
	        modelo.addColumn("Dirección");
	        modelo.addColumn("Activo");
	        modelo.addColumn("Fecha de creación");
	        
	        
	        for (Customer cust : customer.listarPorPais(id)) {
	                modelo.addRow(new Object[]{
	                		cust.getCustomer_id(),
	                		cust.getStore_id(),
	                		cust.getFirst_name(),
	                		cust.getLast_name(),
	                		cust.getEmail(),
	                		addresses.buscar(cust.getAddress_id()).getAddress(),
	                		cust.getActive() == 1 ? "Activo" : "Inactivo",
	                		cust.getCreate_date(),
	                });
	            } 
	}
}
