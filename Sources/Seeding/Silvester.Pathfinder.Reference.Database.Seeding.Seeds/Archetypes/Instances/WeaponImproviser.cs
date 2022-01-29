using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class WeaponImproviser : Template
    {
        public static readonly Guid ID = Guid.Parse("f5d5d1d8-6694-45d6-ba80-f126878762b2");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Weapon Improviser",
                DedicationFeatId = Feats.Instances.WeaponImproviserDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c2214e5b-55e2-47da-86d3-be944d2fa54d"), Type = TextBlockType.Text, Text = "As far as you're concerned, the best weapon to wield is the one that your opponents never see coming. By knowing how to fight effectively with whatever's at hand, you ensure that you're never caught unarmed, and you often get the drop on opponents who mistakenly think they've caught you off guard." };
            yield return new TextBlock { Id = Guid.Parse("a3a35ce1-9aca-43fe-aa8b-875007cdbac2"), Type = TextBlockType.Text, Text = "Whether you're smashing someone over the head with a bar stool, tossing a mug of ale in their face to blind them, or stabbing your foes with a broken bottle, you can find weapons anywhere and employ them creatively whenever a fight breaks out. Because you fight with disposable weapons, you don't need to be as careful with your weapons as other warriors do, and you can break them when needed to win a fight without feeling any regrets later." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26df1c8b-7b7b-42cc-a688-59ba64c70bd1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 199
            };
        }
    }
}
