using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace OPL2LPT_Player
{

    public partial class Form1 : Form
    {

        public VGMPlayer player = new VGMPlayer();

        public Form1()
        {

            AddFont(Properties.Resources.PerfectDos);

            Font FontHuge     = new Font(pfc.Families[0], 23, FontStyle.Regular);
            Font FontBig      = new Font(pfc.Families[0], 20, FontStyle.Regular);
            Font FontNormal   = new Font(pfc.Families[0], 17, FontStyle.Regular);
            Font FontSmaller  = new Font(pfc.Families[0], 14, FontStyle.Regular);
            Font FontSmall    = new Font(pfc.Families[0], 14, FontStyle.Regular);
            Font FontTiny     = new Font(pfc.Families[0], 12, FontStyle.Regular);
            Font Font13       = new Font(pfc.Families[0], 13, FontStyle.Regular);


            InitializeComponent();
            label1.Font = FontHuge;
            label2.Font = FontBig;
            label3.Font = FontNormal;
            label4.Font = FontNormal;
            label5.Font = FontNormal;
            label6.Font = FontNormal;
            label7.Font = FontNormal;
            label8.Font = FontSmall;
            label9.Font = FontSmall;

            authorBox.Font = FontSmaller;
            titleBox.Font = FontSmaller;
            systemBox.Font = FontSmaller;
            dateBox.Font = FontSmaller;
            gameBox.Font = FontSmaller;

            AddButton.Font = FontSmaller;
            DeleteButton.Font = FontSmaller;
            LoadButton.Font = FontSmaller;
            SaveButton.Font = FontSmaller;

            RepeatAll.Font = FontSmall;
            RandomAll.Font = FontSmall;
            RepeatOne.Font = FontSmall;

            playlistBox.Font = FontTiny;
            LPTPort.Font     = Font13;

        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static uint cFonts = 0;
        private void AddFont(byte[] fontdata)
        {
            int fontLength; System.IntPtr dataPointer;

            //We are going to need a pointer to the font data, so we are generating it here
            dataPointer = Marshal.AllocCoTaskMem(fontdata.Length);


            //Copying the fontdata into the memory designated by the pointer
            Marshal.Copy(fontdata, 0, dataPointer, (int)fontdata.Length);

            // Register the font with the system.
            AddFontMemResourceEx(dataPointer, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            //Keep track of how many fonts we've added.
            cFonts += 1;

            //Finally, we can actually add the font to our collection
            pfc.AddMemoryFont(dataPointer, (int)fontdata.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeMeta(playlistBox.GetItemText(playlistBox.SelectedItem));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Video Game Music (*.vgz;*.vgm)|*.vgz;*.vgm";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // playlistBox.ClearSelected();
                    if (playlistBox.Items.Contains(filePath) == false)
                    { playlistBox.Items.Add(filePath); }
                    playlistBox.SelectedItem = filePath;
                }
            }
        }

        private void changeMeta(string filePath)
        {
            // if (player == null) { player = new VGMPlayer() ; }

            try
            {
                Dictionary<string, string> metaData = player.getMetaData(filePath);
                addMetaData(new string[] {metaData["title"],
                                      metaData["author"],
                                      metaData["game"],
                                      metaData["system"],
                                      metaData["date"]});
            }
            catch
            {
                addMetaData(new string[] { "", "", "", "", "" });
            }

        }

        private void addMetaData(string[] items)
        {
            titleBox.Text    = items[0];
            authorBox.Text   = items[1];
            gameBox.Text     = items[2];
            systemBox.Text   = items[3];
            dateBox.Text     = items[4];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (playlistBox.SelectedItem == null) return;

            int    itemToDelete = playlistBox.SelectedIndex;
            string itemText     = playlistBox.GetItemText(playlistBox.SelectedItem);

            playlistBox.SelectedItem = null;
            playlistBox.SelectedItems.Remove(itemText);
            playlistBox.Items.Remove(itemText);

            if (playlistBox.Items.Count == 0) return;

            try   { playlistBox.SelectedItem  = playlistBox.Items[itemToDelete]; }
            catch { playlistBox.SelectedValue = playlistBox.Items[0];            }
            playlistBox.Update();
            playlistBox.Focus();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            List<string> listOfFiles = new List<string>(); 

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string   filePath = openFileDialog.FileName;
                    // playlistBox.ClearSelected();
                    string[] data     = File.ReadAllLines(filePath);
                    foreach(string file in data)
                    {
                        if (File.Exists(file) == true) listOfFiles.Add(file);
                    }
                }
            }

            if (listOfFiles.Count > 0)
            {
                playlistBox.SelectedItem = null;
                playlistBox.Items.Clear();

                foreach (string item in listOfFiles) 
                {
                    playlistBox.Items.Add(item);
                }

                playlistBox.SelectedItem = playlistBox.Items[0]; 
                playlistBox.Update();
                playlistBox.Focus();

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (playlistBox.Items.Count == 0) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string   filePath = saveFileDialog.FileName;

                    File.WriteAllLines(filePath, playlistBox.Items.OfType<string>().ToArray());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playlistBox.SelectedItem == null) return;

            player.PlaySongThread(playlistBox.GetItemText(playlistBox.SelectedItem),
                                  Convert.ToInt16("0x" + LPTPort.Text, 16));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.shouldStop = true;
        }

        private void LPTPort_TextChanged(object sender, EventArgs e)
        {
            if (LPTPort.Text.Length == 0) return;

            bool finished = false;
            while (finished == false && LPTPort.Text.Length > 0)
            {


                string lastChar = LPTPort.Text.Substring(LPTPort.Text.Length - 1, 1);
                try 
                {
                    int tempNum = Int32.Parse(lastChar);
                    finished    = true ;
                }
                catch 
                {
                    LPTPort.Text = LPTPort.Text.Substring(0, LPTPort.Text.Length - 1);
                }
            }

            LPTPort.SelectionStart  = LPTPort.Text.Length;
            LPTPort.SelectionLength = 0;
            
        }


    }
}
