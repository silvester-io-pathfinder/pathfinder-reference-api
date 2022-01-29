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
    public class AerobaticsMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("ae90c7ec-094f-4494-8704-5f2e9bc12dfa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aerobatics Mastery",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d6a8421-7edf-4d52-9474-0fc606d701a0"), Type = TextBlockType.Text, Text = $"You move with grace in flight and can perform amazing aerial stunts. You gain a +2 circumstance bonus to Acrobatics checks to {ToMarkdownLink<Models.Entities.SkillAction>("Maneuver in Flight", SkillActions.Instances.ManeuverInFlight.ID)} and can combine two maneuvers into a single action, such as reversing direction while making a steep ascent or descent or hovering in gale-force winds. The DC of the Acrobatics check is equal to the DC of the most difficult maneuver + 5. If you're legendary in Acrobatics, you can combine three such maneuvers into a single action; the DC of the Acrobatics check is equal to the DC of the most difficult maneuver + 10. Regardless of the combination, these maneuvers rarely allow you to move farther than your fly Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("58c564ad-dcc8-4b65-bce1-887c59fa9848"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c1ee78f-9dc1-4c8e-90e4-70aaad123c1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
