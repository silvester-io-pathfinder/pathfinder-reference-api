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
    public class FlamboyantLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("d36e6db8-0b94-4a13-80cc-c08790ff43a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flamboyant Leap",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76c57c61-45a2-44a1-803f-7a63719de230"), Type = TextBlockType.Text, Text = $"You stylishly leap and deliver a powerful finisher. Make a {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} and attempt one single-action finisher at any point during your jump; the finisher can't be one that includes other movement, such as {ToMarkdownLink<Models.Entities.Feat>("Mobile Finisher", Feats.Instances.MobileFinisher.ID)}. Immediately after the finisher, you fall to the ground if you're in the air, even if you haven't reached the maximum distance of your jump. If the distance you fall is no more than the height of your jump, you take no damage and land upright. When attempting a {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} during a Flamboyant Leap, determine the DC using the {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} DCs, and increase the maximum distance to double your Speed, rather than just your Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0dcbb155-5051-409d-96ca-b6560a0be289"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("d22892b3-1a19-4991-a88b-b2f4a3c861cd"), Feats.Instances.FlamboyantAthlete.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa92fcb0-84ca-40b6-860e-c76f6544c1a9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
