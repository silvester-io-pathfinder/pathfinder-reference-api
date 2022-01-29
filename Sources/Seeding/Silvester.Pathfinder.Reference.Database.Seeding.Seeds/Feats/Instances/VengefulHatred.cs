using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VengefulHatred : Template
    {
        public static readonly Guid ID = Guid.Parse("a3e9d86f-1c1d-486b-8852-023dadb990ef");

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
            yield return new TextBlock { Id = Guid.Parse("c422e9ac-8e45-4154-9e7c-dd9ae75ae16f"), Type = TextBlockType.Text, Text = $"You heart aches for vengeance against those who have wronged your people. Choose one of the following dwarven ancestral foes when you gain Vengeful Hatred: drow, duergar, giant, or orc. You gain a +1 circumstance bonus to damage with weapons and unarmed attacks against creatures with that trait. If your attack would deal more than one weapon die of damage, the bonus is equal to the number of weapon dice or unarmed attack dice." };
            yield return new TextBlock { Id = Guid.Parse("ffe12e0b-4cf1-4318-930b-3d2d5db50118"), Type = TextBlockType.Text, Text = $"In addition, if a creature critically succeeds at an attack against you and deals damage to you, you gain your bonus to damage against that creature for 1 minute regardless of whether it has the chosen trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9b9f05e-a135-481d-8de4-8095a752cac9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
