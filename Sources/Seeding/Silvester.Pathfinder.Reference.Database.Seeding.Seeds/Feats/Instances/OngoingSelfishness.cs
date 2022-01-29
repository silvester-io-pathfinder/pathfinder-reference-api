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
    public class OngoingSelfishness : Template
    {
        public static readonly Guid ID = Guid.Parse("70605fd4-5f39-4b89-b118-d6d6798cb572");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ongoing Selfishness",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df2a6cc1-006a-4274-bb3a-8b25ee6014f2"), Type = TextBlockType.Text, Text = $"Your powerful personality and incredible ego demand that you protect yourself above all else. After you use {ToMarkdownLink<Models.Entities.Feat>("Selfish Shield", Feats.Instances.SelfishShield.ID)}, you gain resistance to all further damage from the triggering enemy until the end of the turn on which you used the reaction. This resistance is equal to half your {ToMarkdownLink<Models.Entities.Feat>("Selfish Shield", Feats.Instances.SelfishShield.ID)} resistance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("09423cac-6341-40da-a4ab-b1fbcf67fd87"), Causes.Instances.Desecrator.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("125d466c-5a5e-44e7-95be-d2b6b44dc051"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62de02d7-1f47-4ee0-a246-f881093ee524"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
