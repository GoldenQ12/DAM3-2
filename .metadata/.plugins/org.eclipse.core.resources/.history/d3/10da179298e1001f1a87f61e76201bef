package vistasBD;

import java.awt.BorderLayout;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import controladoresBD.CountryController;
import controladoresBD.StaffController;
import modelosBD.Country;
import modelosBD.Staff;

import java.awt.Font;
import java.awt.Color;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JComboBox;

public class GestionClientes extends JDialog {

	private static final long serialVersionUID = 1L;
	private final JPanel contentPanel = new JPanel();
	private static StaffController staff = new StaffController(); 
	private static CountryController paises = new CountryController();
	private static JComboBox<String> cbPais;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		try {
			GestionClientes dialog = new GestionClientes();
			dialog.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
			dialog.setVisible(true);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	/**
	 * Create the dialog.
	 */
	public GestionClientes() {
		setBounds(100, 100, 886, 696);
		getContentPane().setLayout(new BorderLayout());
		contentPanel.setBorder(new EmptyBorder(5, 5, 5, 5));
		getContentPane().add(contentPanel, BorderLayout.CENTER);
		contentPanel.setLayout(null);
		{
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
			btnVolver.setBounds(673, 562, 187, 84);
			contentPanel.add(btnVolver);
		}
		{
			JButton btnAltaClientes = new JButton("ALTA CLIENTES");
			btnAltaClientes.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					AltaCliente form = new AltaCliente();
					form.setVisible(true);
				}
			});
			btnAltaClientes.setForeground(new Color(0, 128, 192));
			btnAltaClientes.setFont(new Font("Tahoma", Font.BOLD, 18));
			btnAltaClientes.setBounds(10, 108, 272, 84);
			contentPanel.add(btnAltaClientes);
		}
		{
			JButton btnGestinDeClientes = new JButton("BAJA CLIENTES");
			btnGestinDeClientes.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					BajaCliente form = new BajaCliente();
					form.setVisible(true);
				}
			});
			btnGestinDeClientes.setForeground(new Color(0, 128, 192));
			btnGestinDeClientes.setFont(new Font("Tahoma", Font.BOLD, 18));
			btnGestinDeClientes.setBounds(292, 108, 272, 84);
			contentPanel.add(btnGestinDeClientes);
		}
		{
			JButton btnModificacinDeClientes = new JButton("MODIFICAR CLIENTE");
			btnModificacinDeClientes.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					ModificarCliente form = new ModificarCliente();
					form.setVisible(true);
				}
			});
			btnModificacinDeClientes.setForeground(new Color(0, 128, 192));
			btnModificacinDeClientes.setFont(new Font("Tahoma", Font.BOLD, 18));
			btnModificacinDeClientes.setBounds(575, 108, 272, 84);
			contentPanel.add(btnModificacinDeClientes);
		}
		{
			JButton btnConsultasDeClientes = new JButton("CONSULTAS DE CLIENTES");
			btnConsultasDeClientes.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					MostrarClientes form = new MostrarClientes();
					form.setVisible(true);
				}
			});
			btnConsultasDeClientes.setForeground(new Color(0, 128, 192));
			btnConsultasDeClientes.setFont(new Font("Tahoma", Font.BOLD, 18));
			btnConsultasDeClientes.setBounds(10, 203, 554, 84);
			contentPanel.add(btnConsultasDeClientes);
		}
		{
			JLabel lblGestionDeClientes = new JLabel("GESTION DE CLIENTES");
			lblGestionDeClientes.setHorizontalAlignment(SwingConstants.CENTER);
			lblGestionDeClientes.setForeground(new Color(204, 173, 0));
			lblGestionDeClientes.setFont(new Font("Tahoma", Font.BOLD | Font.ITALIC, 32));
			lblGestionDeClientes.setBounds(0, 34, 873, 35);
			contentPanel.add(lblGestionDeClientes);
		}
		
		
		
		
		
		JLabel lblId_1 = new JLabel("Vendedor:");
		lblId_1.setHorizontalAlignment(SwingConstants.LEFT);
		lblId_1.setForeground(Color.BLACK);
		lblId_1.setFont(new Font("Tahoma", Font.BOLD | Font.ITALIC, 18));
		lblId_1.setBounds(566, 323, 177, 35);
		contentPanel.add(lblId_1);
		
		JComboBox<String> cbVendedor = new JComboBox<String>();
		cbVendedor.setFont(new Font("Tahoma", Font.BOLD | Font.ITALIC, 16));
		cbVendedor.setBounds(673, 323, 174, 35);
		ArrayList<Staff> staf = staff.listarTodos();
		for (Staff item : staf) {
			cbVendedor.addItem(item.getFirst_name());
		}
		
		contentPanel.add(cbVendedor);
		{
			JLabel lblId_1_1 = new JLabel("Pais:");
			lblId_1_1.setHorizontalAlignment(SwingConstants.LEFT);
			lblId_1_1.setForeground(Color.BLACK);
			lblId_1_1.setFont(new Font("Tahoma", Font.BOLD | Font.ITALIC, 18));
			lblId_1_1.setBounds(566, 415, 177, 35);
			contentPanel.add(lblId_1_1);
		}
		{
			cbPais = new JComboBox<String>();
			cbPais.setFont(new Font("Tahoma", Font.BOLD | Font.ITALIC, 16));
			cbPais.setBounds(673, 415, 174, 35);
			contentPanel.add(cbPais);
			ArrayList<Country> paisess = paises.listarTodos();
			for (Country pais : paisess) {
				cbPais.addItem(pais.getCountry());
			}
			
		}
		
		JButton btnConsultasDeClientes_2 = new JButton("CONSULTAS DE CLIENTES POR PAIS");
		btnConsultasDeClientes_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ArrayList<Country> items = paises.listarTodos();
				String nombre = cbPais.getSelectedItem().toString();
				for (Country item : items) {
					if (item.getCountry().equals(nombre)) {
						int id = item.getCountry_id();
						MostrarClientesPorPais form = new MostrarClientesPorPais(id);
						form.setVisible(true);
					}
				}
			}
		});
		btnConsultasDeClientes_2.setForeground(new Color(0, 128, 192));
		btnConsultasDeClientes_2.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnConsultasDeClientes_2.setBounds(10, 393, 554, 84);
		contentPanel.add(btnConsultasDeClientes_2);
		
		JButton btnConsultasDeClientes_3 = new JButton("CONSULTAS DE CLIENTES POR VENDEDOR");
		btnConsultasDeClientes_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ArrayList<Staff> items = staff.listarTodos();
				String nombre = cbVendedor.getSelectedItem().toString();
				for (Staff item : items) {
					if (item.getFirst_name().equals(nombre)) {
						int id = item.getStaff_id();
						MostrarClientesPorVendedor form = new MostrarClientesPorVendedor(id);
						form.setVisible(true);
					}
				}
			}
		});
		btnConsultasDeClientes_3.setForeground(new Color(0, 128, 192));
		btnConsultasDeClientes_3.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnConsultasDeClientes_3.setBounds(10, 298, 554, 84);
		contentPanel.add(btnConsultasDeClientes_3);
	}
}
