namespace DynamicMemory
{
    public partial class Form1 : Form
    {
        private List<object> dynamicObjects;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            var newObj = new object();
            dynamicObjects.Add(newObj);
            lstObjects.Items.Add($"Object {dynamicObjects.Count}");
        }

        private void btnClearMemory_Click(object sender, EventArgs e)
        {
            dynamicObjects.Clear();
            lstObjects.Items.Clear();
            GC.Collect(); // Forzamos la recolección de basura
            MessageBox.Show("Memory cleared!");
        }
    }
    
}

