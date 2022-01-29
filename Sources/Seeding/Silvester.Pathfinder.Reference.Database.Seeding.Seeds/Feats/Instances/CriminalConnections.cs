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
    public class CriminalConnections : Template
    {
        public static readonly Guid ID = Guid.Parse("9b63ddb1-7c91-4d7b-b0a2-0376a50ff7ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Criminal Connections",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eccce86a-ab48-4ad3-994c-a5dcf9abb8c6"), Type = TextBlockType.Text, Text = $"You have dealings with a variety of unsavory characters, which you can leverage to trade favors or meet powerful people. When you're in an area where you have connections (typically a settlement where you've spent downtime building connections or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important criminal, such as a thieves' guild leader, or ask for a favor in exchange for a later favor of your contact's choice. The GM decides the DC based on the difficulty of the favor and the figure's prominence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("dba6b599-5f47-412c-9d3b-98285b0e8492"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("8e05fdbe-9a06-4a21-b5c1-89c840886625"), Feats.Instances.Streetwise.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("da2adeff-dc2b-4856-9561-2e9a5d24b58a"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("ac7c06c7-b5cb-436e-bb8d-5cfae373bffa"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d63a90d3-bad4-4476-a782-10b1f8370e0a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
