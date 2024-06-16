using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FotoKlubas
{
    public partial class Narys_Pagrindinis_Langas : Form
    {
        private int loggedInNarysId;
        private Database dbHelper;

        public Narys_Pagrindinis_Langas()
        {
            InitializeComponent();

            string connectionString = "server=localhost;database=fotoklubas3;uid=root";
            dbHelper = new Database(connectionString);

            // Get the logged-in Username and Password from the login form
            string loggedInUsername = Prisijungimas.LoggedInUsername;
            string loggedInPassword = Prisijungimas.LoggedInPassword;

            // Get the NarysID for the logged-in user
            loggedInNarysId = dbHelper.GetNarysId(loggedInUsername, loggedInPassword);

            // Load photos when the form loads
            LoadPhotos();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload_Photo_Langas photo_langas = new Upload_Photo_Langas();
            photo_langas.PhotoUploaded += Photo_langas_PhotoUploaded;
            photo_langas.ShowDialog();
            this.Show(); // Ensure to show the form back after upload form closes
            LoadPhotos(); // Reload photos after uploading a new one
        }

        private void button_infologin_Click(object sender, EventArgs e)
        {
            Nario_Info_Langas nario_langas = new Nario_Info_Langas();
            nario_langas.ShowDialog();
        }

        private void button_personalinfo_Click(object sender, EventArgs e)
        {
            Nario_Pinformacijos_langas pinfo_langas = new Nario_Pinformacijos_langas();
            pinfo_langas.ShowDialog();
        }

        private void LoadPhotos()
        {
            // Clear existing controls in the Photos panel
            Photos.Controls.Clear();

            // Query to fetch photos belonging to the logged-in user
            string query = "SELECT FotoID, Pavadinimas, Aprasymas, FotoData FROM fotografija " +
                           "WHERE NarysID = @NarysID";
            MySqlParameter[] parameters = {
                new MySqlParameter("@NarysID", loggedInNarysId)
            };

            try
            {
                // Execute query to get photos
                DataTable photos = dbHelper.ExecuteQuery(query, parameters);

                // Log number of rows retrieved for debugging purposes
                Debug.WriteLine($"Number of photos retrieved: {photos.Rows.Count}");

                // Create a FlowLayoutPanel to contain the photo panels
                FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                flowPanel.Dock = DockStyle.Fill;
                flowPanel.AutoScroll = true;

                // Iterate through each photo and create PictureBox controls dynamically
                foreach (DataRow row in photos.Rows)
                {
                    int fotoID = Convert.ToInt32(row["FotoID"]);
                    string pavadinimas = Convert.ToString(row["Pavadinimas"]);
                    string aprasymas = Convert.ToString(row["Aprasymas"]);
                    byte[] fotoData = (byte[])row["FotoData"];

                    // Convert byte array to Image
                    Image image = ByteArrayToImage(fotoData);

                    if (image != null)
                    {
                        // Calculate the size of the PictureBox to maintain aspect ratio
                        int maxWidth = 180; // Maximum width of the PictureBox
                        int maxHeight = 180; // Maximum height of the PictureBox

                        Size imageSize = CalculateAspectRatio(image, maxWidth, maxHeight);

                        // Create a Panel control for each photo
                        Panel panel = new Panel();
                        panel.Size = new Size(imageSize.Width, imageSize.Height); // Adjust the panel size
                        panel.Margin = new Padding(5); // Add margin for spacing

                        // Create a PictureBox control for each photo
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = imageSize; // Set the size of the picture box to maintain aspect ratio
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Zoom the image to fit the box
                        pictureBox.Image = image; // Set the image to the PictureBox
                        pictureBox.Tag = fotoID; // Store the FotoID in the Tag property for later reference

                        // Add a click event handler to open the photo details when clicked
                        pictureBox.Click += (s, args) =>
                        {
                            ShowPhotoPreview(fotoID, pavadinimas, aprasymas, fotoData);
                        };

                        // Add the PictureBox to the Panel
                        panel.Controls.Add(pictureBox);

                        // Add the panel to the FlowLayoutPanel
                        flowPanel.Controls.Add(panel);
                    }
                }

                // Add the FlowLayoutPanel to the Photos panel
                Photos.Controls.Add(flowPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading photos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting byte array to Image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Method to show photo preview when a photo is clicked
        private void ShowPhotoPreview(int fotoID, string pavadinimas, string aprasymas, byte[] fotoData)
        {
            try
            {
                // Convert byte array to Image
                Image originalImage = ByteArrayToImage(fotoData);

                if (originalImage == null)
                {
                    MessageBox.Show("Failed to load photo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new form to display the photo preview
                Form photoPreviewForm = new Form();
                photoPreviewForm.Text = "Photo Preview";

                // Calculate the size of the form based on the original image size and labels
                int formWidth = 1020;
                int formHeight = 800; // Adjust the height as needed

                photoPreviewForm.Size = new Size(formWidth, formHeight);
                photoPreviewForm.StartPosition = FormStartPosition.CenterParent;
                photoPreviewForm.ShowIcon = false;

                // Calculate aspect ratio
                double aspectRatio = (double)originalImage.Width / (double)originalImage.Height;

                // Create a Panel for the photo preview
                Panel picturePanelPreview = new Panel();
                picturePanelPreview.Size = new Size(formWidth - 50, (int)((formWidth - 50) / aspectRatio));
                picturePanelPreview.Location = new Point(20, 80);

                // Create a PictureBox inside the Panel to display the image
                PictureBox pictureBoxPreview = new PictureBox();
                pictureBoxPreview.Image = originalImage;
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxPreview.Dock = DockStyle.Fill;

                // Add PictureBox to the Panel
                picturePanelPreview.Controls.Add(pictureBoxPreview);

                // Create labels for pavadinimas and aprasymas
                Label labelPavadinimas = new Label();
                labelPavadinimas.Text = pavadinimas;
                labelPavadinimas.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                labelPavadinimas.AutoSize = true;
                labelPavadinimas.Location = new Point(20, 10);

                Label labelAprasymas = new Label();
                labelAprasymas.Text = aprasymas;
                labelAprasymas.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                labelAprasymas.AutoSize = true;
                labelAprasymas.Location = new Point(20, 40);

                // Add controls to the form
                photoPreviewForm.Controls.Add(picturePanelPreview);
                photoPreviewForm.Controls.Add(labelPavadinimas);
                photoPreviewForm.Controls.Add(labelAprasymas);

                // Show the photo preview form as a dialog
                photoPreviewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing photo preview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Photo_langas_PhotoUploaded(object sender, EventArgs e)
        {
            LoadPhotos(); // Reload photos after uploading a new one
        }

        private Size CalculateAspectRatio(Image image, int maxWidth, int maxHeight)
        {
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            double ratioX = (double)maxWidth / originalWidth;
            double ratioY = (double)maxHeight / originalHeight;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            return new Size(newWidth, newHeight);
        }


    }
}
