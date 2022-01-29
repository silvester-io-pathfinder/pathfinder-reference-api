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
    public class SacredDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("301a8095-f0fb-444f-add7-9c2a72be2c1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacred Defense",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb5e5fcb-f7f2-4c7f-8db2-464ce713545f"), Type = TextBlockType.Text, Text = $"You call upon your deity to grant you their protective blessing. Attempt a DC 30 Religion check. If you have legendary proficiency in Religion, you can instead attempt a DC 40 Religion check to increase the temporary Hit Points you gain on a successful check to 15 (25 on a critical success)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ac4b6225-0e2e-4984-8290-d6b2d6bea7d3"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("633e3311-15ef-4ec1-9721-c2d3350becaf"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("3f02a1b6-18fc-4057-b792-9105a92dade3"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9a59ec69-2b18-413a-9ad8-50ac6dbc4239"),
                CriticalSuccess = "You gain 10 temporary Hit Points. You lose any remaining temporary Hit Points after 1 minute.",
                Success = "You gain 5 temporary Hit Points. You lose any remaining temporary Hit Points after 1 minute.",
                
                CriticalFailure = "Your deity withholds their blessing. You cannot attempt to call to your deity again for 1 day.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d2cc2a9-e9f5-4f7f-91ca-96ff7a24a0e6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
