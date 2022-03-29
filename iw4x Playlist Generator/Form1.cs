using System.Linq;

namespace iw4x_Playlist_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Generate checkedbox list & order a-z for readability
            foreach (var item in mapList.OrderBy(i => i.Key))
                mapCheckedListBox.Items.Add(item.Key);
        }

        // Called when something is checked
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e) => GenerateString();
        private void RandomToggle_CheckedChanged(object sender, EventArgs e) => GenerateString();

        // Copy generated text to clipboard
        private void CopyButton_Click(object sender, EventArgs e) => Clipboard.SetText(generatedText.Text);

        private void GenerateString()
        {
            var selectedMaps = new List<string>();

            // For each item that is selected get the first Key in mapList dict and grab its Value and use that
            foreach (var item in mapCheckedListBox.CheckedItems)
                selectedMaps.Add(mapList.FirstOrDefault(x => x.Key == item.ToString()).Value);

            // Create a randomized list
            var rnd = new Random();
            var randomSelectedMaps = selectedMaps.OrderBy(item => rnd.Next());

            // Fill the text box for copying
            generatedText.Text = randomToggle.Checked
                ? $"gametype <game_type_here> map {string.Join(" map ", randomSelectedMaps)}"
                : $"gametype <game_type_here> map {string.Join(" map ", selectedMaps)}";
        }

        // Dictionary string,string list easily editable.
        readonly Dictionary<string, string> mapList = new() 
        {
            { "Afghan", "mp_afghan" },
            { "Derail", "mp_derail" },
            { "Estate", "mp_estate" },
            { "Favela", "mp_favela" },
            { "Highrise", "mp_highrise" },
            { "Invasion", "mp_invasion" },
            { "Karachi", "mp_checkpoint" },
            { "Quarry", "mp_quarry" },
            { "Rundown", "mp_rundown" },
            { "Rust", "mp_rust" },
            { "Scrapyard", "mp_boneyard" },
            { "Skidrow", "mp_nightshift" },
            { "Sub Base", "mp_subbase" },
            { "Terminal", "mp_terminal" },
            { "Underpass", "mp_underpass" },
            { "Wasteland", "mp_brecourt" },
            { "Bailout", "mp_complex" },
            { "Crash", "mp_crash" },
            { "Overgrown", "mp_overgrown" },
            { "Salvage", "mp_compact" },
            { "Storm", "mp_storm" },
            { "Carnival", "mp_abandon" },
            { "Fuel", "mp_fuel2" },
            { "Strike", "mp_strike" },
            { "Trailer Park", "mp_trailerpark" },
            { "Vacant", "mp_vacant" },
            { "Nuketown", "mp_nuked" },
            { "Crossfire", "mp_cross_fire" },
            { "Bloc", "mp_bloc" },
            { "Killhouse", "mp_killhouse" },
            { "Bog", "mp_bog_sh" },
            { "Freighter", "mp_cargoship_sh" },
            { "Shipment: Long", "mp_shipment_long" },
            { "Shipment", "mp_shipment" },
            { "Rust: Long", "mp_rust_long" },
            { "Firing Range", "mp_firingrange" },
            { "Chemical Plant", "mp_storm_spring" },
            { "Favela: Tropical", "mp_fav_tropical" },
            { "Estate: Tropical", "mp_estate_tropical" },
            { "Oilrig (SP)", "oilrig" },
            { "Crash: Tropical", "mp_crash_tropical" },
            { "Forgotten City", "mp_bloc_sh" },
            { "Wet Work", "mp_cargoship" }
        };
    }
}