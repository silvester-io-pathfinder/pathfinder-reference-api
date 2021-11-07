using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefendMount : Template
    {
        public static readonly Guid ID = Guid.Parse("7ac58ce1-63cf-4bd0-aaa9-8957ed912330");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defend Mount",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy makes an attack roll against your mount while you're riding it.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c41a1f9-80a9-404b-b8fd-1273ce21d542"), Type = TextBlockType.Text, Text = "You interpose yourself between an attacker and your mount, defending your mount from harm. Use your own AC against the triggering attack instead your mount’s AC. If the triggering attack hits, you take the effects of the attack instead of your mount." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1a380be-63ef-45de-959c-b6410fcd7da0"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c288842-e63d-4add-a17c-b361ca4dcb77"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
