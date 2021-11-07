using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UzunjatiRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("49a05c94-1d44-4d25-ba89-c9a134f33243");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uzunjati Recollection",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c6bef56-13c9-4ca9-bced-a88c4b92b7e3"), Type = TextBlockType.Text, Text = "You tell a story spontaneously from nearly forgotten facts, delving into your memory and entertaining your audience in the process. (action: Recall Knowledge) with a skill in which you have master proficiency, then use (feat: Uzunjati Storytelling) with the same skill. You gain a +1 circumstance bonus to your skill check for (feat: Uzunjati Storytelling) from the added details." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("42d46aa1-b336-4710-89f6-84408c98aac0"), Feats.Instances.UzunjatiStorytelling.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("74c09731-ffc6-4c9f-8c0c-f209650870ca"), Proficiencies.Instances.Master.ID, requiresAssurance: False);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("770431aa-2fda-4beb-be54-2a65cfac80af"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
