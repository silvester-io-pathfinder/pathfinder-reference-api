using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChampionsSacrifice : Template
    {
        public static readonly Guid ID = Guid.Parse("cc6aa59f-ea60-4e70-8d84-5ebeba048930");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Champion's Sacrifice",
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
            yield return new TextBlock { Id = Guid.Parse("4ce05581-2d61-4f03-a778-b0fd6278e562"), Type = TextBlockType.Text, Text = $"You can suffer so that others might live. You can cast the {ToMarkdownLink<Models.Entities.Spell>("champion's sacrifice", Spells.Instances.ChampionsSacrifice.ID)} devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("4a9f61ee-255d-43e6-a935-1252fdeb2aa3"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaa99985-4e54-4d38-8067-d0e65685cde6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
