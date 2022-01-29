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
    public class ImprovedKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("94e68239-ed2f-440c-9014-a4825c3719fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Knockdown",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71302f27-0a7b-4f47-b26c-1b284ec987ed"), Type = TextBlockType.Text, Text = $"You can dash your foe to the ground with a single blow. When you use {ToMarkdownLink<Models.Entities.Feat>("Knockdown", Feats.Instances.Knockdown.ID)}, instead of making a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} followed by a {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}, you can attempt a single {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you do and your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you also apply the critical success effect of a {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}. If you used a two-handed melee weapon for the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you can use the weapon's damage die size instead of the regular die size for the damage from a critical {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2314eb89-1928-42dd-ae99-cd354c82973f"), Feats.Instances.Knockdown.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e8a97783-f220-4e5a-ad4f-6ed52cd9ed26"), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e9f93bd-e744-4aa6-94c0-9f66860496ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
