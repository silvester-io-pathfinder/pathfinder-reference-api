using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Hellspawn : Template
    {
        public static readonly Guid ID = Guid.Parse("1dde245a-2c48-4ef5-82a0-b3f6048330c6");

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
            yield return new TextBlock { Id = Guid.Parse("85baea75-fc54-4f65-90a0-f51f9cbfd341"), Type = TextBlockType.Text, Text = "Your lineage descends from devils, the conniving schemers of Hell's malevolent hierarchy. You're as skilled at noticing lies and twisted wordings as you are at constructing them. You are trained in Deception and Legal Lore. If you were already trained in Deception (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the (feat: Lie to Me) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d8d3a9e-6a2b-4d3f-a489-d90459f937e1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
