using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertText
{
    public partial class ConvertTextForm : Form
    {

        private readonly IFileRepository _fileRepository;
        private string[]? _pathList;
        public ConvertTextForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width-this.Width)/2, (Screen.PrimaryScreen.Bounds.Height-this.Height)/2);    
            _fileRepository = new FileRepository();
        }

        private void selectFilesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog()== DialogResult.OK)
                {
                    _pathList = openFileDialog.FileNames;
                    MessageBox.Show($"Los {_pathList.Length} archivos han sido seleccionados exitosamente");
                    if (_pathList.Length >0)
                    {
                            convertFilesButton.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Los archivos no han sido seleccionados");
                }
            }
        }

        private async void convertFilesButton_Click(object sender, EventArgs e)
        {   
            if ( _pathList != null && _pathList.Length != 0 )
            {
               
                foreach (var filePath in _pathList)
                {
                    if (Path.GetExtension(filePath) == ".txt")
                    {
                        try
                        {
                            string content = await _fileRepository.ReadAsync(filePath);
                            string upperContent = content.ToUpper();
                            await _fileRepository.WriteAsync(Path.Combine(Path.GetDirectoryName(filePath),Path.GetFileNameWithoutExtension(filePath) + "_mayus.txt"), upperContent);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error al convertir el archivo " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Extension del archivo inválido ");
                    }
                }
                MessageBox.Show("Proceso completado");
                

            }

        }
    }
}
