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
    public class SpiritualGuides : Template
    {
        public static readonly Guid ID = Guid.Parse("f07566bf-b070-4864-a9b3-cb5a55138a43");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Guides",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail, but don't critically fail, a Perception check or a skill check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ea2d53f-a948-453e-9697-77f464b3ffb1"), Type = TextBlockType.Text, Text = $"Though no one sees them and only you can hear them, the spirits around you constantly chatter, save when you are raging. Sometimes they're even helpful. You can heed the spirits' guidance to reroll the triggering check, using the second result even if it's worse." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("1c66e2c6-ca57-4781-929f-99a552771930"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("cedab1c9-3d13-40c5-abb2-bea457ba3810"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("0592b1c1-b546-4f6c-aac5-e4bb27b07255"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("6b666c12-d815-4380-9f7a-2a56a1c6a7a9"), Traits.Instances.Fortune.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08571411-7043-4894-b48c-92315ff6a900"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
