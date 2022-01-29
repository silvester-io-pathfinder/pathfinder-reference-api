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
    public class TailSpin : Template
    {
        public static readonly Guid ID = Guid.Parse("88f48407-6e78-49c4-9306-3b74592b068a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tail Spin",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d808781-ff83-4c6b-b42a-3f1cc5dc8a86"), Type = TextBlockType.Text, Text = $"You excel at using your tail as a weapon to upend your foes. Attempt a single Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} up to two adjacent creatures. If you roll a success against a target, you get a critical success against that target instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("10edb3f5-6936-4ce1-9484-49fc277c9390"), Heritages.Instances.TailedGoblin.ID);
            builder.HaveSpecificFeat(Guid.Parse("f1f222da-79a6-4ec1-8daf-da24fd60041d"), Feats.Instances.HardTail.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0255395a-f106-4e78-98b8-d6fa1411fd83"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
