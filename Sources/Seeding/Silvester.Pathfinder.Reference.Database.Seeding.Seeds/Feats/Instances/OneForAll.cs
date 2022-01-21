using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneForAll : Template
    {
        public static readonly Guid ID = Guid.Parse("9de62ddd-9f4c-4987-b60e-ebccadfa5b98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One for All",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adba9dab-a215-4687-a5ea-cf638b8ff3f1"), Type = TextBlockType.Text, Text = "With precisely the right words of encouragement, you bolster an ally's efforts. Designate an ally within 30 feet; this action counts as sufficient preparation to (action: Aid) that ally. When you use the (action: Aid) reaction to help that ally, you can roll Diplomacy in place of the usual check. If your swashbuckler's style is wit and your Diplomacy check to (action: Aid) meets or exceeds the very hard DC for your level, you gain panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fd1fcadc-5de7-490b-83f3-94fa333e7506"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("817911bd-c825-47ea-b400-11b1dbc37cd4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
