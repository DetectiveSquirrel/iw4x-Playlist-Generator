namespace iw4x_Playlist_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var item in mapList)
            {
                mapCheckedListBox.Items.Add(item.Key);
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMaps = new List<string>();

            foreach (var item in mapCheckedListBox.CheckedItems)
            {
                selectedMaps.Add(mapList.FirstOrDefault(x => x.Key == item.ToString()).Value);
            }

            var rnd = new Random();
            var randomSelectedMaps = selectedMaps.OrderBy(item => rnd.Next());
            
            generatedText.Text = randomToggle.Checked
                ? $"gametype <game_type_here> map {string.Join(" map ", randomSelectedMaps)}"
                : $"gametype <game_type_here> map {string.Join(" map ", selectedMaps)}";

        }

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
            { "Cargoship", "mp_cargoship" },
            { "Killhouse", "mp_killhouse" },
            { "Bog", "mp_bog_sh" },
            { "Freighter", "mp_cargoship_sh" },
            { "Long: Shipment", "mp_shipment_long" },
            { "Long: Rust", "mp_rust_long" },
            { "Firing Range", "mp_firingrange" },
            { "Chemical Plant", "mp_storm_spring" },
            { "Tropical: Favela", "mp_fav_tropical" },
            { "Tropical: Estate", "mp_estate_tropical" },
            { "Tropical: Crash", "mp_crash_tropical" },
            { "Forgotten City", "mp_bloc_sh" }
        };
    }
}