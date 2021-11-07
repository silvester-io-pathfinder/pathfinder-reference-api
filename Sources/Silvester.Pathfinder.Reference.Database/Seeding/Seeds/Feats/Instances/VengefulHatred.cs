using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VengefulHatred : Template
    {
        public static readonly Guid ID = Guid.Parse("fe582906-f6b8-4aec-a6fd-3c5b6890148e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vengeful Hatred",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "Your GM can add appropriate creature traits to the ancestral foes list if your character is from a community that commonly fights other types of enemies.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5ab041d-748d-422b-8a52-29b82f4a7b86"), Type = TextBlockType.Text, Text = "You heart aches for vengeance against those who have wronged your people. Choose one of the following dwarven ancestral foes when you gain Vengeful Hatred: drow, duergar, giant, or orc. You gain a +1 circumstance bonus to damage with weapons and unarmed attacks against creatures with that trait. If your attack would deal more than one weapon die of damage, the bonus is equal to the number of weapon dice or unarmed attack dice." };
            yield return new TextBlock { Id = Guid.Parse("7bc5bd16-3915-435e-98ab-469e10e1987a"), Type = TextBlockType.Text, Text = "In addition, if a creature critically succeeds at an attack against you and deals damage to you, you gain your bonus to damage against that creature for 1 minute regardless of whether it has the chosen trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec0e65c1-555d-4afd-9e53-67173c1f88c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
