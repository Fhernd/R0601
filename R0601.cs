using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace R0601
{
    public partial class R0601 : Form
    {
        public R0601()
        {
            InitializeComponent();
        }

        private void R0601_Load(object sender, EventArgs e)
        {
            txtRutaXml.Text = Path.Combine(Application.StartupPath, @"CatalogoProductos.xml");
        }
		
		private void btnXml_Click(object sender, System.EventArgs e)
		{
			// Limpia el componente TreeView:
			trvXml.Nodes.Clear();
			
			// Car el documento XML:
			XmlDocument docXml = new XmlDocument();
			
			try
			{
                docXml.Load(txtRutaXml.Text);
			}
			catch(Exception ex)
			{
                MessageBox.Show(this, "Problema al cargar el documento XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			// Carga el contenido en el componente TreeView:
			ConvertirXmlNodeATreeNode(docXml, trvXml.Nodes);
			
			// Expande todos los nodos:
			trvXml.Nodes[0].ExpandAll();
		}
		
		private void ConvertirXmlNodeATreeNode(XmlNode nodoXml, TreeNodeCollection nodos)
		{
			// Agregar un objeto TreeNode que represnte el nodo XmlNode actual:
			TreeNode nuevoTreeNode = nodos.Add(nodoXml.Name);
			
			// Determina el elemento a mostrar:
			switch(nodoXml.NodeType)
			{
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.XmlDeclaration:
					nuevoTreeNode.Text = String.Format("<?{0} {1}?>", nodoXml.Name, nodoXml.Value) ;
					break;
				case XmlNodeType.Element:
					nuevoTreeNode.Text = String.Format("<{0}>", nodoXml.Name);
					break;
				case XmlNodeType.Attribute:
					nuevoTreeNode.Text = String.Format("ATTRIBUTE: {0}", nodoXml.Name);
					break;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
					nuevoTreeNode.Text = String.Format("{0}", nodoXml.Value);
					break;
				case XmlNodeType.Comment:
					nuevoTreeNode.Text = String.Format("<!--{0}-->", nodoXml.Value);
					break;
			}
			
			// Invocación recursiva por cada atributo del elemento:
			if (nodoXml.Attributes != null)
			{
				foreach(XmlAttribute atributo in nodoXml.Attributes)
				{
					ConvertirXmlNodeATreeNode(atributo, nuevoTreeNode.Nodes);
				}
			}
			
			// Invocación recursiva para cada nodo hijo:
			foreach(XmlNode nodoHijo in nodoXml.ChildNodes)
			{
				ConvertirXmlNodeATreeNode(nodoHijo, nuevoTreeNode.Nodes);
			}
		}
    }
}
