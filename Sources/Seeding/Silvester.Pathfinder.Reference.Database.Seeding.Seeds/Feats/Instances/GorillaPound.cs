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
    public class GorillaPound : Template
    {
        public static readonly Guid ID = Guid.Parse("0ceca4e5-8ce1-41ba-8a93-c1bbd4fe2e7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gorilla Pound",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, while you are in Gorilla Stance, you gain a climb Speed of 15 feet.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89597a1d-3125-4516-89fd-f8559ce161d5"), Type = TextBlockType.Text, Text = $"You pound your chest before slamming into your foes. Attempt an Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}, then make one gorilla slam {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the same target. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you gain a circumstance bonus to the damage roll equal to triple the value of the target's frightened condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ce2869a8-d591-4846-a780-47d146ede46c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("d30bef44-5791-43fe-936b-7ce4020e81d0"), Feats.Instances.GorillaStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("388d8e21-a88a-4a53-8b7c-6c14628dc40d"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("f64cdbdb-6939-4711-8095-985ab36ba5c9"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("e5fb730d-4dfd-49fe-bc70-5b83f438a6ab"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("5e568c27-8c8d-4eb3-810a-39d160bd099a"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beb19eaa-3f33-4429-80c7-df9bac21560c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
