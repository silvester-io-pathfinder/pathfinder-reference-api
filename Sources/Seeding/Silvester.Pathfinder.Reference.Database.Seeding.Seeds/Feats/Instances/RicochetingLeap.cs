using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetingLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("3dbf962c-1c3b-4de1-ac92-ac8f46725d27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricocheting Leap",
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
            yield return new TextBlock { Id = Guid.Parse("6e22413c-00db-457b-b4d5-60f7d6c8f317"), Type = TextBlockType.Text, Text = $"You quickly use your momentum to topple and spring off of foes. You can use {ToMarkdownLink<Models.Entities.Feat>("Wall Jump", Feats.Instances.WallJump.ID)} to make additional jumps off of creatures larger than you as if they were walls. Once per turn when you make an additional jump off of a creature in this way, you can also attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} that creature as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2e540519-8fa9-4aa1-87bd-bd4e75ba914d"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("836619dd-e94e-4966-bc76-4065545299d2"), Feats.Instances.WallJump.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a593fd86-b601-4723-b8d0-3fab6fe48a44"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
