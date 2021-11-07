using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParadoxicalMystery : Template
    {
        public static readonly Guid ID = Guid.Parse("3553ebf2-87e8-4af6-a329-0debfc31015d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paradoxical Mystery",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("114a6649-fec5-4884-8fc8-aab72d8c9f38"), Type = TextBlockType.Text, Text = "The truest depths of your divine mystery are fathomless and contradictory, granting you changing powers that even you can barely begin to fathom. Each day during your daily preparations, choose one basic or advanced domain spell from any domain from the Core Rulebook or another domain to which you have access, or any initial or advanced revelation spell from another mystery. You gain that spell as a revelation spell until your next daily preparations, and it has the (trait: cursebound) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5114a0eb-5bf7-4701-a078-7986b7af4d37"), Feats.Instances.GreaterRevelation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72a9b1aa-3659-4669-b28e-1f1d4644b883"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
