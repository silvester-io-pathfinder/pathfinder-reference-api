using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtraSquishy : Template
    {
        public static readonly Guid ID = Guid.Parse("1643a162-6943-4ff9-bba8-777dfa5f2074");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extra Squishy",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ceb8abb5-9e1e-42be-a8e7-21402e0cea7e"), Type = TextBlockType.Text, Text = $"Your rubbery physique makes it easier for you to wedge yourself into tight spaces and more difficult for your enemies to dislodge you. You become trained in Acrobatics. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice. If you roll a success to {ToMarkdownLink<Models.Entities.SkillAction>("Squeeze", SkillActions.Instances.Squeeze.ID)}, you get a critical success instead. While you're {ToMarkdownLink<Models.Entities.SkillAction>("Squeezing", SkillActions.Instances.Squeeze.ID)}, you gain a +4 circumstance bonus to your Fortitude or Reflex DCs against attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} you or otherwise move you from your space." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fb553aa4-8d45-40df-a7c5-a8b1bcf63a84"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad8b6c37-fccb-42ea-88ed-dee8b859c438"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
