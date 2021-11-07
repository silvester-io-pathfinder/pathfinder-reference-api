using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Hellspawn : Template
    {
        public static readonly Guid ID = Guid.Parse("618f8426-8df7-487a-b19e-f90b98b61d7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hellspawn",
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
            yield return new TextBlock { Id = Guid.Parse("acc5a30c-39a3-47b5-ad86-41934f5e59f1"), Type = TextBlockType.Text, Text = "Your lineage descends from devils, the conniving schemers of Hell&#39;s malevolent hierarchy. You&#39;re as skilled at noticing lies and twisted wordings as you are at constructing them. You are trained in Deception and Legal Lore. If you were already trained in Deception (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the (feat: Lie to Me) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c38085d-0868-45e8-8265-55845a4d36a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
