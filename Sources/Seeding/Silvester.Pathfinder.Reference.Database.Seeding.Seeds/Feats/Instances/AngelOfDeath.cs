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
    public class AngelOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("10d387e2-2adb-4b2c-8551-5ef31d6f3791");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Angel of Death",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adcc8330-81f9-4552-bc3b-34a39040109f"), Type = TextBlockType.Text, Text = $"All your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against a creature you have {ToMarkdownLink<Models.Entities.Feat>("Marked for Death", Feats.Instances.MarkForDeath.ID)} have the {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} trait, causing the mark to be instantly killed when reduced to 0 Hit Points. When killed in this way, attempts to communicate with it, return it to life, turn it into an undead, or otherwise disturb its afterlife fail unless the effect's counteract level is higher than half your level when you killed the creature (rounded up), or originates from an artifact or a deity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2e988c0c-5348-4da3-ad15-fd2bc7ce46d8"), Feats.Instances.AssassinDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67a0a351-51e2-421b-b3c0-6cf47a9c3005"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
