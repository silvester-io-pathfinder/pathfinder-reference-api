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
    public class Mercy : Template
    {
        public static readonly Guid ID = Guid.Parse("9798316b-20b7-47b1-bb08-7103277f4a80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mercy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae54bb69-1b01-40da-b157-8698c54cedbd"), Type = TextBlockType.Text, Text = $"Your touch relieves fear and restores movement. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)}, you can attempt to counteract a {ToMarkdownLink<Models.Entities.Spell>("fear", Spells.Instances.Fear.ID)} effect or an effect imposing the paralyzed condition on the target, in addition to the other benefits of {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19620eea-4d10-4cbd-816f-398195e79bdf"), Feats.Instances.BlessedOneDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("69b1a3c3-c8d3-48fa-81d7-3cdfdc8e5bbe"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("0fef4e5f-f267-46a0-b575-678aebec6dd1"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("b694b0cb-3fdd-4b8b-b745-881e47feed6e"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6102b4a3-ecae-4849-96bd-6ebca1bb738f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
