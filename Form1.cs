using System.Diagnostics;
using System.Runtime.InteropServices;

namespace undertalesaveeditor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int key);

        private string[] labels;
        private string defaultFile;
        private string normalLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UNDERTALE\\file0");
        private string openFile = "";

        public Form1()
        {
            InitializeComponent();

            labels = new string[] {
                "Name",
                "LOVE",
                "Health",
                "Max Health",
                "Attack",
                "Weapon Strength",
                "Defense",
                "Armor Defense",
                "SP",
                "EXP",
                "Gold",
                "Kills",
                "Inventory Slot 1",
                "Phone 1",
                "Inventory Slot 2",
                "Phone 2",
                "Inventory Slot 3",
                "Phone 3",
                "Inventory Slot 4",
                "Phone 4",
                "Inventory Slot 5",
                "Phone 5",
                "Inventory Slot 6",
                "Phone 6",
                "Inventory Slot 7",
                "Phone 7",
                "Inventory Slot 8",
                "Phone 8",
                "Weapon",
                "Armor",
                "",
                "",
                "",
                "",
                "Undyne Trigger Override",
                "Fun",
                "Hardmode",
                "True Pacifist",
                "Disable Random Encounters",
                "",
                "Spared Last",
                "Escaped Last",
                "Killed Last",
                "Bored Last",
                "Status Dummy",
                "In Battle",
                "Type Heart Transition",
                "",
                "",
                "",
                "Animation Index",
                "Cooked Noodles",
                "Name Color",
                "Spared",
                "Escaped",
                "Dialogues Skipped",
                "Murderlevel Override",
                "Spared Specific",
                "Fast Text Skip",
                "",
                "Tutorial Froggit Encountered",
                "Pushed Rock 1",
                "Pushed Rock 2",
                "Pushed Rock 3",
                "Candy Taken",
                "Pushed Rock 4",
                "Spared Napstablook",
                "Waited Toriel",
                "",
                "",
                "Greeted Toriel",
                "Flirted Toriel",
                "Call Mom Toriel",
                "Ruins Switches Pressed",
                "Disobeyed Toriel",
                "Status Toriel",
                "Choice Flavor",
                "Status Creepy Tundra",
                "",
                "",
                "Know Water Sausage",
                "Wrong Switches Pressed",
                "Status Doggo",
                "Status Dogcouple",
                "Status Greaterdog",
                "Status Lesserdog",
                "Status Snowman",
                "Status Snowdrake",
                "Choice Harder Puzzle",
                "Spider Donations Total",
                "Nicecream Donations Total",
                "",
                "Choice Ate Left Spaghetti",
                "Xoxo Resets",
                "Toggled Snow Switch",
                "Got Snowpoff Gold",
                "Flirted Papyrus Fight",
                "Status Papyrus",
                "Fought Papyrus",
                "Bpants Alt Dialogue",
                "Progress Tundra Battles",
                "",
                "Status Inn",
                "Stayed Inn",
                "Betrayed Gyftrot",
                "Armor Papyrus Inquiry",
                "Choice Papyrus Inquiry",
                "Armor Undyne Saw",
                "Strong Tough Glove",
                "Nicecream Business",
                "Punchcards Bought",
                "Status Shyren",
                "Papyrus Sink Event Occurred",
                "Got Couch Gold",
                "",
                "Have Umbrella",
                "Music Statue On",
                "",
                "Dated Papyrus",
                "Dated Sans1",
                "Choice Mkid Umbrella",
                "Interacted Garbage Savepoint",
                "Status Stable",
                "Dated Napstablook",
                "Current Napstablook Song",
                "Aaron Woshua Event",
                "Conversation Emblem",
                "Creepy Friend Seen",
                "Saved Mkid",
                "Undyne Difficulty",
                "Got Ribbon",
                "",
                "Got Toyknife",
                "Got Bscotch Pie",
                "Got Quiche",
                "Got Tutu",
                "Got Ballet Shoes",
                "Got Artifact",
                "Got Spacefood",
                "Got Instant Noodles",
                "Got Frying Pan",
                "Got Apron",
                "Got Glamburger Trashcan",
                "Got Gold Trashcan",
                "Got Dagger",
                "Got Locket",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Spared Froggit",
                "Spared Whimsun",
                "Spared Moldsmal",
                "Spared Loox",
                "Spared Vegetoid",
                "Spared Migosp",
                "Spared Snowdrake",
                "Spared Icecap",
                "Spared Gyftrot",
                "Spared Doggo",
                "",
                "Spared Lesserdog",
                "Spared Greatdog",
                "Spared Aaron",
                "Spared Moldsmalx",
                "Spared Woshua",
                "Spared Temmie",
                "Spared Maddummy",
                "Spared Vulkin",
                "Spared Tsunderplane",
                "Spared Pyrope",
                "Spared Finalfroggit",
                "Spared Whimsalot",
                "Spared Astigmatism",
                "Spared Madjick",
                "Spared Finalknight",
                "Spared Endogeny",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Conversation Toriel Pacifist",
                "Conversation Sans Pacifist",
                "Conversation Undyne Pacifist",
                "Unlock Napsta Pacifist",
                "Conversation Papyrus Pacifist",
                "Conversation Alphys Pacifist",
                "Conversation Asgore Pacifist",
                "Conversation Mettaton Pacifist",
                "Conversation Napstablook Pacifist",
                "Kills Area Pointer",
                "Kills",
                "Kills Ruins",
                "Kills Tundra",
                "Kills Water",
                "Kills Hotland",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Genocide Ruins",
                "Genocide Tundra",
                "Genocide Water",
                "Genocide Hotland",
                "Genocide Core",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Nicecream Business2",
                "Killed Undyne Ex",
                "Killed Glad Dummy",
                "Killed Snowman",
                "Interacted Crosswords",
                "Robbed Snowdin",
                "Robbed Core",
                "",
                "",
                "",
                "Used Recovery Item",
                "Interacted Fakedog",
                "Delivered Seatea",
                "Delivered Cinnabun",
                "Delivered Hotdog",
                "Tem Sell Parameter1",
                "Tem Sell Parameter2",
                "Status Hotel",
                "",
                "Allergy Tem Talked",
                "Glowshrooms On",
                "Fighting Sans",
                "Geeettttttt Dunked On",
                "",
                "",
                "Tundra Stick Broken",
                "Temmie College Paid",
                "Fun Call Occurred",
                "Completed Tile Puzzle",
                "Interacted Clamgirl",
                "Conversation Elderpuzzles",
                "Status Sosorry",
                "Encountered Glyde",
                "Check Papyrus Kitchen Again",
                "Undyne Spears Anger",
                "",
                "Conversation Toriel Sms",
                "Conversation Sms Parameters",
                "Failed Defusing",
                "Stepped Green Tile",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Dimensional Box A",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Dimensional Box A End",
                "Dimensional Box B",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Dimensional Box B End",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Status Undyne",
                "Undyne Hp Left",
                "Fought Undyne",
                "Poured Water Ground",
                "Conversation Papyrus Calls",
                "Choice Maddummy",
                "Completed Piano Puzzle",
                "Progress Water Battles",
                "Progress Water2 Battles",
                "",
                "Rain Parameters",
                "",
                "",
                "",
                "Rain Parameters End",
                "",
                "Have Water",
                "Disable Alphys Calls",
                "Disable Alphys Statuses",
                "Conversation Alphys Statuses",
                "Quick Battle",
                "Laser1 Off",
                "Laser2 On",
                "Laser2 Off",
                "Completed Shoot Puzzle1",
                "Completed Shoot Puzzle2",
                "Conveyor Puzzle Variable",
                "Failed Jetpack Segment",
                "Hot Dogs Money Spent",
                "Conversation Hotdogs",
                "Headdogs",
                "Reached Headdogs Limit",
                "Muffet Bribe Price",
                "Muffet Bribe Money Spent",
                "Unused",
                "Status Yellow Button",
                "Reset Bridgeseed Puzzle",
                "Won Ball Game",
                "Fall Animation Parameters",
                "Dated Undyne",
                "Undyne Expression",
                "Choice Meal Grillby",
                "Unused",
                "Unclear",
                "Unused",
                "Bombs Defused",
                "Fought Muffet",
                "Killed Muffet",
                "Current Elevator Floor",
                "Completed Shoot Puzzle3",
                "Completed Shoot Puzzle4",
                "Asked Papyrus Rg",
                "Killed Rg",
                "Spider Sale Big Spendings",
                "Laser3 Off",
                "Conversation Wares",
                "Conversation Mettaton",
                "Conversation Alphys",
                "Progress Hotland Battles",
                "Got Napstablook Friend Req",
                "",
                "",
                "",
                "Dated Sans2",
                "Got Alphys Advice1",
                "Got Alphys Advice2",
                "Got Alphys Advice3",
                "Got Alphys Advice4",
                "",
                "",
                "",
                "",
                "",
                "Progress Core Battles",
                "Turn Mettaton",
                "Killed Mettaton",
                "Progress Core Battles2",
                "",
                "",
                "",
                "Alphys Expression",
                "Current Final Floor",
                "Rode Long Elevator",
                "Unlocked Mettaton House",
                "Choice Flamey Challenge",
                "Status Bpants",
                "Conversation Mtt",
                "Conversation Girls",
                "",
                "",
                "Water Taken Amount",
                "Water Wasted Amount",
                "Got Gun",
                "Got Cowboy Hat",
                "Got Mystery Key",
                "Got Face Steak",
                "",
                "",
                "",
                "",
                "Progress Early Story",
                "",
                "Have Castle Key1",
                "Have Castle Key2",
                "Unlocked Latchkey",
                "Early Story Parameter1",
                "Early Story Parameter2",
                "Told Asgore Ready",
                "Experience Cosmic Garbage",
                "Riverman Destination",
                "Got Tem Village Hint",
                "Tem Boat Version",
                "Called Already",
                "",
                "",
                "Papyrus And Undyne",
                "",
                "",
                "",
                "",
                "Conversation Undyne Mad",
                "",
                "",
                "",
                "",
                "Killed Flowey",
                "Killed Asgore",
                "",
                "",
                "",
                "Completed Truelab",
                "Truelab Events",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "Truelab Events End",
                "Dated Alphys",
                "Status Undyne Letter",
                "Popato Chisps Bought",
                "Conversation Onionsan",
                "Got Sans Room Key",
                "",
                "Seen Cast",
                "Fighting Asriel",
                "Conversation Asriel Fight",
                "But It Refused",
                "Dreamed Asriel Fight",
                "",
                "Saved Lost Soul",
                "",
                "",
                "Saved Lost Soul End",
                "Toggle Final Beam",
                "Plot Over",
                "Conversation Asriel2",
                "Choice Left Toriel",
                "Plot",
                "Items Enabled on Menu",
                "Stats Enabled on Menu",
                "Cell Enabled On Menu",
                "",
                "Room",
                "Time (must be changed in undertale.ini too)"
            };
            defaultFile = @"Gaster
                1		
                20		
                20		
                10		
                0		
                10		
                0		
                4
                0		
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                0		
                0
                3		
                4		
                0
                0
                0
                0
                0
                66		
                0
                0		
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0		
                0
                0
                0
                0
                0
                0
                0
                10
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0		
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                14		
                0		
                0		
                0		
                0		
                0		
                0		
                0		
                0		
                0		
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0		
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0
                0	
                1	
                1	
                1	
                232
                4	
                0";

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.RowCount = labels.Length;

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label();
                label.Text = labels[i];
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(label, 0, i);

                TextBox box = new TextBox();
                box.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(box, 1, i);
            }

            tableLayoutPanel1.ResumeLayout();

            loadNormalLocation();
        }

        private bool load(string lfile)
        {
            tableLayoutPanel1.SuspendLayout();

            if (lfile.StartsWith("\n"))
            {
                lfile = lfile.Substring(lfile.IndexOf("\n"), "\n".Length);
            }

            string[] lines = lfile.Split("\n");
            if (lines.Length >= labels.Length)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    tableLayoutPanel1.GetControlFromPosition(1, i).Text = lines[i].Trim();
                }
                tableLayoutPanel1.ResumeLayout();

                return true;
            }
            else
            {
                loadDefault();
                MessageBox.Show("Invalid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tableLayoutPanel1.ResumeLayout();

                return false;
            }
        }

        private void loadFile(string file)
        {
            try
            {
                if (load(File.ReadAllText(file)))
                {
                    this.Text = Path.GetFullPath(file) + " - " + "Undertale Save Editor";
                    openFile = file;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                loadDefault();
            }
        }

        private void loadNormalLocation()
        {
            if (File.Exists(normalLocation))
            {
                loadFile(normalLocation);
            }
            else
            {
                loadDefault();
            }
        }

        private void loadDefault()
        {
            load(defaultFile);
            this.Text = "New - Undertale Save Editor";
            openFile = "";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            tableLayoutPanel1.ResumeLayout();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = openFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog1.FileName);
            }
        }

        private string aggregateFile()
        {
            string str = "";
            for (int i = 0; i < labels.Length; i++)
            {
                str += tableLayoutPanel1.GetControlFromPosition(1, i).Text.Trim() + "\n";
            }

            str = str.Substring(0, str.LastIndexOf("\n"));
            return str;
        }

        private void save()
        {
            File.WriteAllText(openFile, aggregateFile());
            this.Text = Path.GetFullPath(openFile) + " - " + "Undertale Save Editor";
        }

        private void saveAs()
        {
            saveFileDialog1.InitialDirectory = openFile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile = saveFileDialog1.FileName;
                save();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // File currently open or shift key is being held down
            if (openFile == "" || ((GetAsyncKeyState(16) & 0x8000) > 0))
            {
                saveAs();
            }
            else
            {
                save();
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undertale Save Editor v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString() + "\nEverything sourced from https://tomat.dev/undertale.", "About Undertale Save Editor");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                if (tableLayoutPanel1.GetControlFromPosition(0, i).Text.ToLower().Contains(searchBox.Text.ToLower()) || tableLayoutPanel1.GetControlFromPosition(1, i).Text.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    tableLayoutPanel1.GetControlFromPosition(1, i).Focus();
                    break;
                }
            }
        }

        private void openUrl(string url)
        {
            webform webForm = new webform(url);
            webForm.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/rooms");
        }

        private void flagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/flags");
        }

        private void battlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/battles");
        }

        private void saveStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/save");
        }

        private void monstersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/monsters");
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/items");
        }

        private void papyrusAndUndyneCallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/calls");
        }

        private void funEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/fun");
        }

        private void debugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl("https://tomat.dev/undertale/debugmode");
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Click += searchButton_Click;
            this.AcceptButton = b;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void reloadToolStripButton_Click(object sender, EventArgs e)
        {
            loadFile(openFile);
        }

        private void openFolderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer", Path.GetDirectoryName(Path.GetFullPath(openFile)));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
