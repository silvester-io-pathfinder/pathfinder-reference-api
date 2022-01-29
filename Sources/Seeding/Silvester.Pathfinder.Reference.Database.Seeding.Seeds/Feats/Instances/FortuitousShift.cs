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
    public class FortuitousShift : Template
    {
        public static readonly Guid ID = Guid.Parse("15742f62-1a61-4bcb-aedc-10a18e9d3865");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fortuitous Shift",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c8c73fb-c9f5-4d73-bdf9-eca385224fba"), Type = TextBlockType.Text, Text = $"You have grown more comfortable with your penchant for supernatural disappearance. The flat check DC of your {ToMarkdownLink<Models.Entities.Feat>("Unexpected Shift", Feats.Instances.UnexpectedShift.ID)} feat decreases to 11, and you are no longer dazzled if you succeed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("118a5a9b-83a7-42b8-b9ab-959bec092c12"), Feats.Instances.UnexpectedShift.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("82fd0985-100d-43b5-a97c-1524797338dc"), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cc7c309-e6d2-454c-856b-a0a030ba331d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
