using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("ed4b1775-f8e7-47b6-9b9f-6b68256a083c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Performance",
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
            yield return new TextBlock { Id = Guid.Parse("a89df480-07f6-4ba7-bdf7-6fa22e439761"), Type = TextBlockType.Text, Text = $"Your performances are especially distracting, allowing your allies to {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} away with ease. When you {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} an ally who is trying to {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)}, instead of the usual effects of {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)}, you can roll a Performance check and use that result to determine the outcome of the diversion, instead of the ally rolling a Deception check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6733953c-7866-4d29-b987-7f412d3ba887"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("786ecb6b-b2a5-418c-8962-32ad8581e687"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
