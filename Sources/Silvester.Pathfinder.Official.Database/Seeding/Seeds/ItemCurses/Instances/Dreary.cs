using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Dreary : Template
    {
        public static readonly Guid ID = Guid.Parse("75b47175-fb61-4cf2-90dd-466970f59b76");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Dreary",
                Usage = "curses armor",
                Level = 3
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df529fb2-6e29-4350-b747-012e2d9400b8"), Type = TextBlockType.Text, Text = "When you invest this armor, a personal-sized cloud appears over your head and begins to rain on you, and the armor fuses to you. This extinguishes uncovered flames and soaks other objects you are carrying or holding, potentially ruining them. Cold conditions are one step worse under the cloud, and at the GM’s discretion it might cause other problems, such as interfering with sleep." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c6e8c62-8786-481c-9944-f1a849df0228"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Conjuration.ID;
        }
    }
}
