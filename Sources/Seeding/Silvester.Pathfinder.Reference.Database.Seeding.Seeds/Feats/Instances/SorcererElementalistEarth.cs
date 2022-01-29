using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("3860d9b4-7cde-4b11-b40b-21cb7e60e4fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Earth",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fb28957-a365-4095-918c-8194fc829b02"), Type = TextBlockType.Text, Text = $"You replace your initial bloodline spell with the initial earth elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("crushing ground", Spells.Instances.CrushingGround.ID)}), and your advanced bloodline spell (if you get it) with the advanced earth elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("stone lance", Spells.Instances.StoneLance.ID)})." };
            yield return new TextBlock { Id = Guid.Parse("2dc20f7b-0891-41c0-a49c-35ad4b8beee0"), Type = TextBlockType.Text, Text = $"You can only select this option if your bloodline's elemental type is earth." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d567beb-a29b-44af-a5c2-ae5920981c51"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
