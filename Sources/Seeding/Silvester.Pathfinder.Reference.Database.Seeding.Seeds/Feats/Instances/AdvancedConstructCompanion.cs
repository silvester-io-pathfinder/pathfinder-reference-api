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
    public class AdvancedConstructCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("b0140fbb-5b89-4148-8d32-c202c63de803");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Construct Companion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("257ec1d0-eab6-42df-9511-d58cc4f473f3"), Type = TextBlockType.Text, Text = $"You've upgraded your construct companion's power and decision-making ability. It becomes an advanced construct companion (G&amp;G pg. 33). During an encounter, even if you don't use the {ToMarkdownLink<Models.Entities.SkillAction>("Command a Minion", SkillActions.Instances.CommandAnAnimal.ID)} action, your construct companion can still use 1 action on your turn that round to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} or {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("50aa089a-d2ec-4aef-b276-8a24a9433c89"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d39f32a-b9eb-40cf-9dab-b6e35d9e0b8b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
